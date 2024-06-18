namespace FestasInfantis.WinApp.ModuloConfiguracaoDesconto
{
    public partial class TelaConfiguracaoDescontoForm : Form
    {
        private ConfiguracaoDesconto configuracao;
        public ConfiguracaoDesconto Configuracao
        {
            get => configuracao;
            set
            {
                txtPorcentagemAluguel.Value = value.PorcentagemPorAluguel;
                txtPorcentagemMaxima.Value = value.PorcentagemMaxima;
            }
        }

        public TelaConfiguracaoDescontoForm(ConfiguracaoDesconto configuracaoAtual)
        {
            InitializeComponent();

            Configuracao = configuracaoAtual;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            decimal porcentagemDesconto = txtPorcentagemAluguel.Value;
            decimal porcentagemMaxima = txtPorcentagemMaxima.Value;

            configuracao = new ConfiguracaoDesconto(porcentagemDesconto, porcentagemMaxima);

            List<string> erros = configuracao.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
