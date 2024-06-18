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

            byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(configuracao, options);

            File.WriteAllBytes(caminho, registrosEmBytes);
        }

        public ConfiguracaoDesconto ObterConfiguracao()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return new ConfiguracaoDesconto();

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            JsonSerializerOptions options = new JsonSerializerOptions();

            ConfiguracaoDesconto configuracao =
                JsonSerializer.Deserialize<ConfiguracaoDesconto>(registrosEmBytes, options);

            return configuracao;
        }
    }
}
