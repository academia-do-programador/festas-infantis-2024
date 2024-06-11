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
            ConfiguracaoDesconto configuracaoAtual = repositorio.ObterConfiguracao();

            TelaConfiguracaoDescontoForm telaConfiguracao = new TelaConfiguracaoDescontoForm(configuracaoAtual);

            DialogResult resultado = telaConfiguracao.ShowDialog();

            if (resultado != DialogResult.OK) return;

            repositorio.GravarConfiguracao(telaConfiguracao.ConfiguracaoDesconto);

            TelaPrincipalForm.Instancia.AtualizarRodape("A configuração foi salva com sucesso!");
        }
    }
}
