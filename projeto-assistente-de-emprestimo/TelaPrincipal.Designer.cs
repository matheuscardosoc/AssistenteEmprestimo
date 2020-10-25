namespace AssistenteEmprestimo
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.txtAnalise = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMeses = new System.Windows.Forms.Button();
            this.btnPagamentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo do Empréstimo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taxa de Juros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de Pagamentos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pagamento Mensal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(440, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Análise do Empréstimo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSaldo.Location = new System.Drawing.Point(235, 6);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(158, 26);
            this.txtSaldo.TabIndex = 5;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // txtTaxa
            // 
            this.txtTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTaxa.Location = new System.Drawing.Point(235, 50);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(158, 26);
            this.txtTaxa.TabIndex = 6;
            this.txtTaxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxa_KeyPress);
            // 
            // txtMeses
            // 
            this.txtMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMeses.Location = new System.Drawing.Point(235, 94);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(158, 26);
            this.txtMeses.TabIndex = 7;
            this.txtMeses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeses_KeyPress);
            // 
            // txtPagamento
            // 
            this.txtPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPagamento.Location = new System.Drawing.Point(235, 138);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(158, 26);
            this.txtPagamento.TabIndex = 8;
            this.txtPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagamento_KeyPress);
            // 
            // txtAnalise
            // 
            this.txtAnalise.BackColor = System.Drawing.Color.White;
            this.txtAnalise.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnalise.Location = new System.Drawing.Point(444, 29);
            this.txtAnalise.Multiline = true;
            this.txtAnalise.Name = "txtAnalise";
            this.txtAnalise.ReadOnly = true;
            this.txtAnalise.Size = new System.Drawing.Size(330, 199);
            this.txtAnalise.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalcular.Location = new System.Drawing.Point(16, 197);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(377, 31);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular Pagamento Mensal";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Enabled = false;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovo.Location = new System.Drawing.Point(16, 234);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(377, 31);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo Empréstimo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Location = new System.Drawing.Point(444, 234);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(330, 31);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnMeses
            // 
            this.btnMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMeses.Location = new System.Drawing.Point(399, 94);
            this.btnMeses.Name = "btnMeses";
            this.btnMeses.Size = new System.Drawing.Size(27, 26);
            this.btnMeses.TabIndex = 13;
            this.btnMeses.Text = "X";
            this.btnMeses.UseVisualStyleBackColor = true;
            this.btnMeses.Click += new System.EventHandler(this.btnMeses_Click);
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPagamentos.Location = new System.Drawing.Point(399, 138);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Size = new System.Drawing.Size(27, 26);
            this.btnPagamentos.TabIndex = 14;
            this.btnPagamentos.Text = "X";
            this.btnPagamentos.UseVisualStyleBackColor = true;
            this.btnPagamentos.Click += new System.EventHandler(this.btnPagamentos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.btnPagamentos);
            this.Controls.Add(this.btnMeses);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAnalise);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assistente de Empréstimo";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.TextBox txtAnalise;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMeses;
        private System.Windows.Forms.Button btnPagamentos;
    }
}

