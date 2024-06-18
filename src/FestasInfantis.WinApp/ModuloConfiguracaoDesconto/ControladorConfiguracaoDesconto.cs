namespace FestasInfantis.WinApp.ModuloConfiguracaoDesconto
{
    public class ControladorConfiguracaoDesconto
    {
        IRepositorioConfiguracaoDesconto repositorioConfiguracao;

        public ControladorConfiguracaoDesconto(IRepositorioConfiguracaoDesconto repositorioConfiguracao)
        {
            this.repositorioConfiguracao = repositorioConfiguracao;
        }

        public void Configurar()
        {
            ConfiguracaoDesconto configuracaoAtual = repositorioConfiguracao.ObterConfiguracao();

            TelaConfiguracaoDescontoForm telaConfiguracao =
                new TelaConfiguracaoDescontoForm(configuracaoAtual);

            DialogResult resultado = telaConfiguracao.ShowDialog();

            if (resultado != DialogResult.OK) return;

            ConfiguracaoDesconto configuracaoEscolhida = telaConfiguracao.Configuracao;

            repositorioConfiguracao.GravarConfiguracao(configuracaoEscolhida);

            TelaPrincipalForm.Instancia.AtualizarRodape("A configuração foi salva com sucesso!");
        }
    }
}
