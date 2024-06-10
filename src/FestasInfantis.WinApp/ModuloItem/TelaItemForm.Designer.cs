namespace FestasInfantis.WinApp.ModuloItem
{
    partial class TelaItemForm
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
            lblValor = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            txtId = new TextBox();
            lblId = new Label();
            txtValor = new NumericUpDown();
            btnCancelar = new Button();
            btnGravar = new Button();
            ((System.ComponentModel.ISupportInitialize)txtValor).BeginInit();
            SuspendLayout();
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 11.25F);
            lblValor.Location = new Point(50, 105);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(46, 20);
            lblValor.TabIndex = 16;
            lblValor.Text = "Valor:";
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 11.25F);
            txtDescricao.Location = new Point(102, 70);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(407, 27);
            txtDescricao.TabIndex = 15;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 11.25F);
            lblDescricao.Location = new Point(19, 72);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(77, 20);
            lblDescricao.TabIndex = 14;
            lblDescricao.Text = "Descrição:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F);
            txtId.Location = new Point(102, 37);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 13;
            txtId.Text = "0";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11.25F);
            lblId.Location = new Point(71, 40);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 12;
            lblId.Text = "Id:";
            // 
            // txtValor
            // 
            txtValor.DecimalPlaces = 2;
            txtValor.Font = new Font("Segoe UI", 11.25F);
            txtValor.Location = new Point(102, 103);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(120, 27);
            txtValor.TabIndex = 17;
            txtValor.ThousandsSeparator = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(419, 154);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 41);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(323, 154);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(90, 41);
            btnGravar.TabIndex = 18;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 207);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "TelaItemForm";
            Text = "Cadastro de Item";
            ((System.ComponentModel.ISupportInitialize)txtValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblValor;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txtId;
        private Label lblId;
        private NumericUpDown txtValor;
        private Button btnCancelar;
        private Button btnGravar;
    }
}