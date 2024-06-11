using FestasInfantis.WinApp.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloConfiguracaoDesconto
{
    public class ControladorConfiguracaoDesconto
    {
        IRepositorioConfiguracaoDesconto repositorio;

        public ControladorConfiguracaoDesconto(IRepositorioConfiguracaoDesconto repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Configurar()
        {
            TelaConfiguracaoDescontoForm telaConfiguracao = new TelaConfiguracaoDescontoForm();

            DialogResult resultado = telaConfiguracao.ShowDialog();

            if (resultado != DialogResult.OK) return;

            ConfiguracaoDesconto configuracao = new ConfiguracaoDesconto();

            repositorio.GravarConfiguracao(configuracao);

            TelaPrincipalForm.Instancia.AtualizarRodape("A configuração foi salva com sucesso!");
        }
    }
}
