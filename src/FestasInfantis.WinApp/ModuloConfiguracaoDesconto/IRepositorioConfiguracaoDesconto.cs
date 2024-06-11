using FestasInfantis.WinApp.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloConfiguracaoDesconto
{
    public interface IRepositorioConfiguracaoDesconto
    {
        ConfiguracaoDesconto ObterConfiguracao();
        void GravarConfiguracao(ConfiguracaoDesconto configuracao);
    }
}
