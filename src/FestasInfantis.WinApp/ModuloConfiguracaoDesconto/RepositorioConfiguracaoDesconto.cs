using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloConfiguracaoDesconto
{
    public class RepositorioConfiguracaoDesconto : IRepositorioConfiguracaoDesconto
    {
        private string caminho = $"C:\\temp\\FestasInfantis\\configuracao.json";

        public void GravarConfiguracao(ConfiguracaoDesconto configuracao)
        {
            FileInfo arquivo = new FileInfo(caminho);

            arquivo.Serializar(configuracao);
        }

        public ConfiguracaoDesconto ObterConfiguracao()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return new ConfiguracaoDesconto();

            return arquivo.Deserializar<ConfiguracaoDesconto>();
        }
    }
}
