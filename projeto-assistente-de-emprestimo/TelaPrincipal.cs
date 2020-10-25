using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistenteEmprestimo
{
    public partial class frmPrincipal : Form
    {
        private bool computarPagamento;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            computarPagamento = true;
            btnPagamentos.Visible = false;
            btnMeses.Visible = true;
            txtMeses.ReadOnly = false;
            txtMeses.BackColor = Color.White;
            txtPagamento.Text = "";
            txtPagamento.ReadOnly = true;
            txtPagamento.BackColor = Color.LightYellow;
            btnCalcular.Text = "Calcular Pagamento Mensal";
        }

        private void btnMeses_Click(object sender, EventArgs e)
        {
            computarPagamento = false;
            btnPagamentos.Visible = true;
            btnMeses.Visible = false;
            txtMeses.Text = "";
            txtMeses.ReadOnly = true;
            txtMeses.BackColor = Color.LightYellow;
            txtPagamento.ReadOnly = false;
            txtPagamento.BackColor = Color.White;
            btnCalcular.Text = "Calcular Número de Pagamentos";
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            btnPagamentos.PerformClick();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double saldo, taxa;
            // leitura dos campos informados pelo usuario
            // verifica ser os campos estao vazios
            if (txtSaldo.Text != "")
            {
                saldo = Convert.ToDouble(txtSaldo.Text);
            }
            else
            {
                MessageBox.Show("Informe o Saldo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSaldo.Focus();
                return;
            }
            if (txtTaxa.Text != "")
            {
                taxa = Convert.ToDouble(txtTaxa.Text);
            }
            else
            {
                MessageBox.Show("Informe a Taxa de Juros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaxa.Focus();
                return;
            }
            // cria um objeto do tipo Emprestimo
            Emprestimo emprestimo = new Emprestimo(saldo, taxa);
            // realiza o calculo dependendo da opcao selecionada
            if (computarPagamento)
            {
                int meses;
                // calcula o pagamento mensal
                if (txtMeses.Text != "")
                {
                    meses = Convert.ToInt32(txtMeses.Text);
                    if (meses == 0)
                    {
                        MessageBox.Show("O Número de Pagamentos deve ser maior que zero.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMeses.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Informe o Número de Pagamentos.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMeses.Focus();
                    return;
                }
                double pagamento = emprestimo.CalcularValorMensal(meses);
                txtPagamento.Text = String.Format("{0:f2}", pagamento);
            }
            else
            {
                double pagamento;
                // calcula o número de meses
                if (txtPagamento.Text != "")
                {
                    pagamento = Convert.ToDouble(txtPagamento.Text);
                    if (pagamento == 0.0)
                    {
                        MessageBox.Show("O Pagamento Mensal deve ser maior que zero.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPagamento.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Informe o Pagamento Mensal.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPagamento.Focus();
                    return;
                }
                int meses = emprestimo.CalcularNumeroMeses(pagamento);
                txtMeses.Text = meses.ToString();
            }
            // apresenta os detalhes da analise do emprestimo
            txtAnalise.Text = emprestimo.AnaliseEmprestimo();
            // habilita/desabilita os botões
            btnCalcular.Enabled = false;
            btnNovo.Enabled = true;
            btnNovo.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (computarPagamento)
            {
                txtPagamento.Text = "";
            }
            else
            {
                txtMeses.Text = "";
            }
            txtAnalise.Text = "";
            btnCalcular.Enabled = true;
            btnNovo.Enabled = false;
            txtSaldo.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar >= '0' && e.KeyChar <= '9')
                {
                    e.Handled = false;
                }
                else if ((int)e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == ',' || e.KeyChar == '.')
                {
                    // substitui o ponto por vírgula
                    e.KeyChar = ',';
                    if (txtSaldo.Text.IndexOf(",") == -1)
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else if ((int)e.KeyChar == 13)
                {
                    txtTaxa.Focus();
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                // substitui o ponto por vírgula
                e.KeyChar = ',';
                if (txtTaxa.Text.IndexOf(",") == -1)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if ((int)e.KeyChar == 13)
            {
                if (computarPagamento)
                {
                    txtMeses.Focus();
                }
                else
                {
                    txtPagamento.Focus();
                }
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 13)
            {
                btnCalcular.Focus();
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                // substitui o ponto por vírgula
                e.KeyChar = ',';
                if (txtPagamento.Text.IndexOf(",") == -1)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if ((int)e.KeyChar == 13)
            {
                btnCalcular.Focus();
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
