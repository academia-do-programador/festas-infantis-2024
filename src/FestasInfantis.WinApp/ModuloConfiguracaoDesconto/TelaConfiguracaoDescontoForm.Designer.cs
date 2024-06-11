namespace FestasInfantis.WinApp.ModuloConfiguracaoDesconto
{
    partial class TelaConfiguracaoDescontoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtPorcentagemMaxima = new NumericUpDown();
            lblPorcentagemMaxima = new Label();
            txtPorcentagemAluguel = new NumericUpDown();
            lblPorcentagemAluguel = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPorcentagemMaxima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPorcentagemAluguel).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPorcentagemMaxima);
            groupBox1.Controls.Add(lblPorcentagemMaxima);
            groupBox1.Controls.Add(txtPorcentagemAluguel);
            groupBox1.Controls.Add(lblPorcentagemAluguel);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 178);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Porcentagens de Desconto:";
            // 
            // txtPorcentagemMaxima
            // 
            txtPorcentagemMaxima.DecimalPlaces = 2;
            txtPorcentagemMaxima.Font = new Font("Segoe UI", 11.25F);
            txtPorcentagemMaxima.Location = new Point(295, 111);
            txtPorcentagemMaxima.Name = "txtPorcentagemMaxima";
            txtPorcentagemMaxima.Size = new Size(70, 27);
            txtPorcentagemMaxima.TabIndex = 3;
            // 
            // lblPorcentagemMaxima
            // 
            lblPorcentagemMaxima.AutoEllipsis = true;
            lblPorcentagemMaxima.Font = new Font("Segoe UI", 11.25F);
            lblPorcentagemMaxima.Location = new Point(17, 113);
            lblPorcentagemMaxima.Name = "lblPorcentagemMaxima";
            lblPorcentagemMaxima.Size = new Size(272, 25);
            lblPorcentagemMaxima.TabIndex = 2;
            lblPorcentagemMaxima.Text = "Máximo de Porcentagem de Desconto:";
            lblPorcentagemMaxima.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPorcentagemAluguel
            // 
            txtPorcentagemAluguel.DecimalPlaces = 2;
            txtPorcentagemAluguel.Font = new Font("Segoe UI", 11.25F);
            txtPorcentagemAluguel.Location = new Point(295, 50);
            txtPorcentagemAluguel.Name = "txtPorcentagemAluguel";
            txtPorcentagemAluguel.Size = new Size(70, 27);
            txtPorcentagemAluguel.TabIndex = 1;
            // 
            // lblPorcentagemAluguel
            // 
            lblPorcentagemAluguel.AutoSize = true;
            lblPorcentagemAluguel.Font = new Font("Segoe UI", 11.25F);
            lblPorcentagemAluguel.Location = new Point(108, 52);
            lblPorcentagemAluguel.Name = "lblPorcentagemAluguel";
            lblPorcentagemAluguel.Size = new Size(181, 20);
            lblPorcentagemAluguel.TabIndex = 0;
            lblPorcentagemAluguel.Text = "Porcentagem por Aluguel:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(351, 198);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 41);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(255, 198);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(90, 41);
            btnGravar.TabIndex = 2;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaConfiguracaoDescontoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 251);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            Name = "TelaConfiguracaoDescontoForm";
            Text = "Configuração de Descontos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPorcentagemMaxima).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPorcentagemAluguel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown txtPorcentagemAluguel;
        private Label lblPorcentagemAluguel;
        private NumericUpDown txtPorcentagemMaxima;
        private Label lblPorcentagemMaxima;
        private Button btnCancelar;
        private Button btnGravar;
    }
}