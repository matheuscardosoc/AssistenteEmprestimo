using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistenteEmprestimo
{
    class Emprestimo
    {
        // atributos
        private double saldo, taxa, pagamento, jurosMensal;
        private int meses;
        private double saldoEmprestimo, pagamentoFinal;

        public Emprestimo(double saldo, double taxa)
        {
            this.saldo = saldo;
            this.taxa = taxa;
            jurosMensal = taxa / 1200;
        }

        public double CalcularValorMensal(int meses)
        {
            this.meses = meses;
            if (taxa == 0)
            {
                pagamento = saldo / meses;
            }
            else
            {
                double multiplicador = Math.Pow(1 + jurosMensal, meses);
                pagamento = saldo * jurosMensal * multiplicador / (multiplicador - 1);
            }
            RealizarAnalise();
            return pagamento;
        }

        public int CalcularNumeroMeses(double pagamento)
        {
            this.pagamento = pagamento;
            if (taxa == 0)
            {
                meses = (int)(saldo / pagamento);
            }
            else
            {
                meses = (int)((Math.Log(pagamento) -
                Math.Log(pagamento - saldo * jurosMensal)) / Math.Log(1 + jurosMensal));
            }
            RealizarAnalise();
            return meses;
        }

        public string AnaliseEmprestimo()
        {
            // monta o resultado da análise
            StringBuilder texto = new StringBuilder();
            texto.Append("Saldo do Empréstimo: R$ ");
            texto.Append(String.Format("{0:f2}", saldo));
            texto.Append("\r\nTaxa de Juros: ");
            texto.Append(String.Format("{0:f2}", taxa) + "%");
            texto.Append("\r\n\r\n");
            texto.Append(Convert.ToString(meses - 1));
            texto.Append(" Pagamentos de R$ ");
            texto.Append(String.Format("{0:f2}", pagamento));
            texto.Append("\r\nPagamento Final de: R$ ");
            texto.Append(String.Format("{0:f2}", pagamentoFinal));
            texto.Append("\r\nTotal de Pagamentos: R$ ");
            texto.Append(String.Format("{0:f2}", (meses - 1) * pagamento + pagamentoFinal));
            texto.Append("\r\nJuros Pagos: R$ ");
            texto.Append(String.Format("{0:f2}", (meses - 1) * pagamento + pagamentoFinal - saldo));
            return texto.ToString();
        }

        private void RealizarAnalise()
        {
            pagamento = Math.Round(pagamento, 2);
            saldoEmprestimo = saldo;
            for (int i = 1; i <= meses - 1; i++)
            {
                saldoEmprestimo += saldoEmprestimo * jurosMensal - pagamento;
            }
            pagamentoFinal = saldoEmprestimo;
            if (pagamentoFinal > pagamento)
            {
                saldoEmprestimo += saldoEmprestimo * jurosMensal - pagamento;
                pagamentoFinal = saldoEmprestimo;
                meses++;
            }
        }
    }
}
