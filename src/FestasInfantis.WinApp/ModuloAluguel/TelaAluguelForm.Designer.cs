namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            lblId = new Label();
            txtId = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pnlEndereco = new GroupBox();
            txtNumero = new TextBox();
            lblNumero = new Label();
            txtEstado = new TextBox();
            lblEstado = new Label();
            txtRua = new TextBox();
            lblRua = new Label();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            lblBairro = new Label();
            lblCidade = new Label();
            groupBox1 = new GroupBox();
            txtHorarioTermino = new DateTimePicker();
            txtHorarioInicio = new DateTimePicker();
            lblHorarioTermino = new Label();
            txtDataFesta = new DateTimePicker();
            lblData = new Label();
            lblHorarioInicio = new Label();
            tabPage2 = new TabPage();
            cmbEntrada = new ComboBox();
            label1 = new Label();
            cmbTemas = new ComboBox();
            lblNomeTema = new Label();
            pnlDadosAluguel = new GroupBox();
            toolStrip1 = new ToolStrip();
            btnCalcular = new ToolStripButton();
            txtValorTema = new TextBox();
            label3 = new Label();
            txtPorcentagemDesconto = new TextBox();
            label5 = new Label();
            txtValorSinal = new TextBox();
            txtValorDesconto = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtValorPendente = new TextBox();
            lblValorPendente = new Label();
            cmbClientes = new ComboBox();
            lblNomeCliente = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            pnlEndereco.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            pnlDadosAluguel.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11.25F);
            lblId.Location = new Point(31, 44);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 11.25F);
            txtId.Location = new Point(57, 41);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(77, 27);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 11.25F);
            tabControl1.Location = new Point(31, 96);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(550, 347);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pnlEndereco);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(542, 314);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados da Festa";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlEndereco
            // 
            pnlEndereco.Controls.Add(txtNumero);
            pnlEndereco.Controls.Add(lblNumero);
            pnlEndereco.Controls.Add(txtEstado);
            pnlEndereco.Controls.Add(lblEstado);
            pnlEndereco.Controls.Add(txtRua);
            pnlEndereco.Controls.Add(lblRua);
            pnlEndereco.Controls.Add(txtCidade);
            pnlEndereco.Controls.Add(txtBairro);
            pnlEndereco.Controls.Add(lblBairro);
            pnlEndereco.Controls.Add(lblCidade);
            pnlEndereco.Font = new Font("Segoe UI", 12F);
            pnlEndereco.Location = new Point(22, 157);
            pnlEndereco.Name = "pnlEndereco";
            pnlEndereco.Size = new Size(468, 139);
            pnlEndereco.TabIndex = 5;
            pnlEndereco.TabStop = false;
            pnlEndereco.Text = "Dados do Endereço:";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 11.25F);
            txtNumero.Location = new Point(351, 103);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 27);
            txtNumero.TabIndex = 7;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 11.25F);
            lblNumero.Location = new Point(282, 106);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(66, 20);
            lblNumero.TabIndex = 18;
            lblNumero.Text = "Número:";
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Segoe UI", 11.25F);
            txtEstado.Location = new Point(351, 35);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(100, 27);
            txtEstado.TabIndex = 4;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 11.25F);
            lblEstado.Location = new Point(291, 38);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 16;
            lblEstado.Text = "Estado:";
            // 
            // txtRua
            // 
            txtRua.Font = new Font("Segoe UI", 11.25F);
            txtRua.Location = new Point(83, 70);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(368, 27);
            txtRua.TabIndex = 5;
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Font = new Font("Segoe UI", 11.25F);
            lblRua.Location = new Point(40, 73);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(37, 20);
            lblRua.TabIndex = 14;
            lblRua.Text = "Rua:";
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 11.25F);
            txtCidade.Location = new Point(83, 35);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(184, 27);
            txtCidade.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Segoe UI", 11.25F);
            txtBairro.Location = new Point(83, 103);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(184, 27);
            txtBairro.TabIndex = 6;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI", 11.25F);
            lblBairro.Location = new Point(25, 106);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(52, 20);
            lblBairro.TabIndex = 11;
            lblBairro.Text = "Bairro:";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 11.25F);
            lblCidade.Location = new Point(18, 38);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(59, 20);
            lblCidade.TabIndex = 10;
            lblCidade.Text = "Cidade:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHorarioTermino);
            groupBox1.Controls.Add(txtHorarioInicio);
            groupBox1.Controls.Add(lblHorarioTermino);
            groupBox1.Controls.Add(txtDataFesta);
            groupBox1.Controls.Add(lblData);
            groupBox1.Controls.Add(lblHorarioInicio);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(25, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 135);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data e Hora:";
            // 
            // txtHorarioTermino
            // 
            txtHorarioTermino.CustomFormat = "HH:mm";
            txtHorarioTermino.Format = DateTimePickerFormat.Custom;
            txtHorarioTermino.Location = new Point(163, 96);
            txtHorarioTermino.Name = "txtHorarioTermino";
            txtHorarioTermino.Size = new Size(200, 29);
            txtHorarioTermino.TabIndex = 9;
            txtHorarioTermino.Value = new DateTime(2024, 6, 10, 15, 0, 0, 0);
            // 
            // txtHorarioInicio
            // 
            txtHorarioInicio.CustomFormat = "HH:mm";
            txtHorarioInicio.Format = DateTimePickerFormat.Custom;
            txtHorarioInicio.Location = new Point(163, 61);
            txtHorarioInicio.Name = "txtHorarioInicio";
            txtHorarioInicio.Size = new Size(200, 29);
            txtHorarioInicio.TabIndex = 9;
            txtHorarioInicio.Value = new DateTime(2024, 6, 10, 13, 0, 0, 0);
            // 
            // lblHorarioTermino
            // 
            lblHorarioTermino.AutoSize = true;
            lblHorarioTermino.Font = new Font("Segoe UI", 11.25F);
            lblHorarioTermino.Location = new Point(15, 97);
            lblHorarioTermino.Name = "lblHorarioTermino";
            lblHorarioTermino.Size = new Size(142, 20);
            lblHorarioTermino.TabIndex = 8;
            lblHorarioTermino.Text = "Horário de Termino:";
            // 
            // txtDataFesta
            // 
            txtDataFesta.Font = new Font("Segoe UI", 11.25F);
            txtDataFesta.Format = DateTimePickerFormat.Short;
            txtDataFesta.Location = new Point(163, 28);
            txtDataFesta.Name = "txtDataFesta";
            txtDataFesta.Size = new Size(124, 27);
            txtDataFesta.TabIndex = 0;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 11.25F);
            lblData.Location = new Point(54, 33);
            lblData.Name = "lblData";
            lblData.Size = new Size(103, 20);
            lblData.TabIndex = 3;
            lblData.Text = "Data da Festa:";
            // 
            // lblHorarioInicio
            // 
            lblHorarioInicio.AutoSize = true;
            lblHorarioInicio.Font = new Font("Segoe UI", 11.25F);
            lblHorarioInicio.Location = new Point(33, 64);
            lblHorarioInicio.Name = "lblHorarioInicio";
            lblHorarioInicio.Size = new Size(124, 20);
            lblHorarioInicio.TabIndex = 6;
            lblHorarioInicio.Text = "Horário de Início:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cmbEntrada);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(cmbTemas);
            tabPage2.Controls.Add(lblNomeTema);
            tabPage2.Controls.Add(pnlDadosAluguel);
            tabPage2.Controls.Add(cmbClientes);
            tabPage2.Controls.Add(lblNomeCliente);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(542, 314);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados do Aluguel";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbEntrada
            // 
            cmbEntrada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEntrada.Font = new Font("Segoe UI", 11.25F);
            cmbEntrada.FormattingEnabled = true;
            cmbEntrada.Location = new Point(97, 58);
            cmbEntrada.Name = "cmbEntrada";
            cmbEntrada.Size = new Size(167, 28);
            cmbEntrada.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(28, 61);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 16;
            label1.Text = "Entrada:";
            // 
            // cmbTemas
            // 
            cmbTemas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTemas.Font = new Font("Segoe UI", 11.25F);
            cmbTemas.FormattingEnabled = true;
            cmbTemas.Location = new Point(342, 24);
            cmbTemas.Name = "cmbTemas";
            cmbTemas.Size = new Size(181, 28);
            cmbTemas.TabIndex = 10;
            // 
            // lblNomeTema
            // 
            lblNomeTema.AutoSize = true;
            lblNomeTema.Font = new Font("Segoe UI", 11.25F);
            lblNomeTema.Location = new Point(288, 28);
            lblNomeTema.Name = "lblNomeTema";
            lblNomeTema.Size = new Size(48, 20);
            lblNomeTema.TabIndex = 10;
            lblNomeTema.Text = "Tema:";
            // 
            // pnlDadosAluguel
            // 
            pnlDadosAluguel.Controls.Add(toolStrip1);
            pnlDadosAluguel.Controls.Add(txtValorTema);
            pnlDadosAluguel.Controls.Add(label3);
            pnlDadosAluguel.Controls.Add(txtPorcentagemDesconto);
            pnlDadosAluguel.Controls.Add(label5);
            pnlDadosAluguel.Controls.Add(txtValorSinal);
            pnlDadosAluguel.Controls.Add(txtValorDesconto);
            pnlDadosAluguel.Controls.Add(label4);
            pnlDadosAluguel.Controls.Add(label2);
            pnlDadosAluguel.Controls.Add(txtValorPendente);
            pnlDadosAluguel.Controls.Add(lblValorPendente);
            pnlDadosAluguel.Font = new Font("Segoe UI", 12F);
            pnlDadosAluguel.Location = new Point(12, 100);
            pnlDadosAluguel.Name = "pnlDadosAluguel";
            pnlDadosAluguel.Size = new Size(524, 194);
            pnlDadosAluguel.TabIndex = 6;
            pnlDadosAluguel.TabStop = false;
            pnlDadosAluguel.Text = "Dados de Pagamento: ";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCalcular });
            toolStrip1.Location = new Point(3, 25);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(518, 37);
            toolStrip1.TabIndex = 18;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.ImageScaling = ToolStripItemImageScaling.None;
            btnCalcular.ImageTransparentColor = Color.Magenta;
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Padding = new Padding(5);
            btnCalcular.Size = new Size(76, 34);
            btnCalcular.Text = "Calcular";
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtValorTema
            // 
            txtValorTema.Enabled = false;
            txtValorTema.Font = new Font("Segoe UI", 11.25F);
            txtValorTema.Location = new Point(131, 108);
            txtValorTema.Name = "txtValorTema";
            txtValorTema.ReadOnly = true;
            txtValorTema.Size = new Size(100, 27);
            txtValorTema.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(21, 111);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 16;
            label3.Text = "Valor do Tema:";
            // 
            // txtPorcentagemDesconto
            // 
            txtPorcentagemDesconto.Enabled = false;
            txtPorcentagemDesconto.Font = new Font("Segoe UI", 11.25F);
            txtPorcentagemDesconto.Location = new Point(131, 75);
            txtPorcentagemDesconto.Name = "txtPorcentagemDesconto";
            txtPorcentagemDesconto.ReadOnly = true;
            txtPorcentagemDesconto.Size = new Size(56, 27);
            txtPorcentagemDesconto.TabIndex = 17;
            txtPorcentagemDesconto.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(17, 78);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 16;
            label5.Text = "% de Desconto:";
            // 
            // txtValorSinal
            // 
            txtValorSinal.Enabled = false;
            txtValorSinal.Font = new Font("Segoe UI", 11.25F);
            txtValorSinal.Location = new Point(131, 141);
            txtValorSinal.Name = "txtValorSinal";
            txtValorSinal.ReadOnly = true;
            txtValorSinal.Size = new Size(100, 27);
            txtValorSinal.TabIndex = 15;
            // 
            // txtValorDesconto
            // 
            txtValorDesconto.Enabled = false;
            txtValorDesconto.Font = new Font("Segoe UI", 11.25F);
            txtValorDesconto.Location = new Point(411, 108);
            txtValorDesconto.Name = "txtValorDesconto";
            txtValorDesconto.ReadOnly = true;
            txtValorDesconto.Size = new Size(100, 27);
            txtValorDesconto.TabIndex = 13;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(255, 105);
            label4.Name = "label4";
            label4.Size = new Size(150, 33);
            label4.TabIndex = 10;
            label4.Text = "Valor com Desconto:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(25, 144);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 14;
            label2.Text = "Valor do Sinal:";
            // 
            // txtValorPendente
            // 
            txtValorPendente.Enabled = false;
            txtValorPendente.Font = new Font("Segoe UI", 11.25F);
            txtValorPendente.Location = new Point(411, 141);
            txtValorPendente.Name = "txtValorPendente";
            txtValorPendente.ReadOnly = true;
            txtValorPendente.Size = new Size(100, 27);
            txtValorPendente.TabIndex = 12;
            // 
            // lblValorPendente
            // 
            lblValorPendente.AutoSize = true;
            lblValorPendente.Font = new Font("Segoe UI", 11.25F);
            lblValorPendente.Location = new Point(294, 144);
            lblValorPendente.Name = "lblValorPendente";
            lblValorPendente.Size = new Size(111, 20);
            lblValorPendente.TabIndex = 11;
            lblValorPendente.Text = "Valor Pendente:";
            // 
            // cmbClientes
            // 
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.Font = new Font("Segoe UI", 11.25F);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(97, 24);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(167, 28);
            cmbClientes.TabIndex = 9;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Font = new Font("Segoe UI", 11.25F);
            lblNomeCliente.Location = new Point(36, 28);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(58, 20);
            lblNomeCliente.TabIndex = 10;
            lblNomeCliente.Text = "Cliente:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(491, 496);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 41);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(395, 496);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(90, 41);
            btnGravar.TabIndex = 20;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 542);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(tabControl1);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "TelaAluguelForm";
            Text = "Cadastro de Aluguéis";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            pnlEndereco.ResumeLayout(false);
            pnlEndereco.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            pnlDadosAluguel.ResumeLayout(false);
            pnlDadosAluguel.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DateTimePicker txtDataFesta;
        private Label lblData;
        private GroupBox pnlEndereco;
        private Label lblHorarioInicio;
        private Label lblHorarioTermino;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private Label lblBairro;
        private Label lblCidade;
        private TextBox txtRua;
        private Label lblRua;
        private TextBox txtEstado;
        private Label lblEstado;
        private GroupBox pnlDadosAluguel;
        private Label label1;
        private TextBox txtValorSinal;
        private Label label2;
        private TextBox txtValorDesconto;
        private TextBox txtValorPendente;
        private Label lblValorPendente;
        private Label label4;
        private TextBox txtValorTema;
        private Label label3;
        private Label lblNomeTema;
        private ComboBox cmbTemas;
        private ComboBox cmbClientes;
        private TextBox txtPorcentagemDesconto;
        private Label label5;
        private Label lblNomeCliente;
        private TextBox txtNumero;
        private Label lblNumero;
        private ComboBox cmbEntrada;
        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnGravar;
        private ToolStrip toolStrip1;
        private ToolStripButton btnCalcular;
        private DateTimePicker txtHorarioTermino;
        private DateTimePicker txtHorarioInicio;
    }
}