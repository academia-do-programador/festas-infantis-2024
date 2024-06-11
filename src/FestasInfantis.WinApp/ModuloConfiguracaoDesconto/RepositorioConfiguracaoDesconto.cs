using FestasInfantis.WinApp.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloConfiguracaoDesconto
{
    public class RepositorioConfiguracaoDesconto : IRepositorioConfiguracaoDesconto
    {
        private string caminho = $"C:\\temp\\FestasInfantis\\configuracao.json";

        public void GravarConfiguracao(ConfiguracaoDesconto configuracao)
        {

        }

        public ConfiguracaoDesconto ObterConfiguracao()
        {
            throw new NotImplementedException();
        }
    }
}
