using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloConfiguracaoDesconto
{
    public partial class TelaConfiguracaoDescontoForm : Form
    {
        private ConfiguracaoDesconto configuracaoDesconto;
        public ConfiguracaoDesconto ConfiguracaoDesconto
        {
            get => configuracaoDesconto;
            set
            {
                txtPorcentagemAluguel.Value = value.PorcentagemPorAluguel;
                txtPorcentagemMaxima.Value = value.PorcentagemMaxima;
            }
        }

        public TelaConfiguracaoDescontoForm(ConfiguracaoDesconto configuracaoAtual)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfiguracaoDesconto = configuracaoAtual;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            decimal porcentagemDesconto = txtPorcentagemAluguel.Value;
            decimal porcentagemMaxima = txtPorcentagemMaxima.Value;

            configuracaoDesconto = new ConfiguracaoDesconto(porcentagemDesconto, porcentagemMaxima);

            List<string> erros = configuracaoDesconto.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
