namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Desconto
    {
        public float PorcentagemPorAluguel { get; set; }
        public float PorcentagemMaxima { get; set; }

        public Desconto() { }

        public Desconto(float porcentagemPorAluguel, float porcentagemMaxima)
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
