using FestasInfantis.WinApp.ModuloAluguel;
using System.Text.Json;

namespace FestasInfantis.WinApp.ModuloConfiguracaoDesconto
{
    public class RepositorioConfiguracaoDesconto : IRepositorioConfiguracaoDesconto
    {
        private string caminho = $"C:\\temp\\FestasInfantis\\configuracao.json";

        public void GravarConfiguracao(ConfiguracaoDesconto configuracao)
        {
            FileInfo arquivo = new FileInfo(caminho);

            arquivo.Directory.Create();

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };

            byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(this, options);

            File.WriteAllBytes(caminho, registrosEmBytes);
        }

        public ConfiguracaoDesconto ObterConfiguracao()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return new ConfiguracaoDesconto();

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            return JsonSerializer.Deserialize<ConfiguracaoDesconto>(registrosEmBytes);
        }
    }
}
