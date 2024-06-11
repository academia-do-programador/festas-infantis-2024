using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloConfiguracaoDesconto
{
    public partial class TelaConfiguracaoDescontoForm : Form
    {
        ConfiguracaoDesconto configuracaoDesconto;

        public TelaConfiguracaoDescontoForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            float porcentagemDesconto = (float)txtPorcentagemAluguel.Value;
            float porcentagemMaxima = (float)txtPorcentagemMaxima.Value;

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
