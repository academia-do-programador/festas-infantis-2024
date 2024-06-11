namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ConfiguracaoDesconto
    {
        public decimal PorcentagemPorAluguel { get; set; }
        public decimal PorcentagemMaxima { get; set; }

        public ConfiguracaoDesconto()
        {
            PorcentagemPorAluguel = 0.0m;
            PorcentagemMaxima = 0.0m;
        }

        public ConfiguracaoDesconto(decimal porcentagemPorAluguel, decimal porcentagemMaxima)
        {
            PorcentagemPorAluguel = porcentagemPorAluguel;
            PorcentagemMaxima = porcentagemMaxima;
        }

        public List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (PorcentagemPorAluguel > PorcentagemMaxima)
                erros.Add("A porcentagem por aluguel não pode ultrapassar a porcentagem máxima!");

            return erros;
        }
    }
}
