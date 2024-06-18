namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class DadosPagamentoAluguel
    {
        public decimal ValorEntrada { get; set; }
        public decimal ValorTema { get; set; }
        public decimal ValorComDesconto { get; set; }
        public decimal ValorPendente { get; set; }
        public decimal ValorPercentualCliente { get; set; }

        public DadosPagamentoAluguel()
        {

        }

        public DadosPagamentoAluguel(
            decimal valorEntrada,
            decimal valorTema,
            decimal valorComDesconto,
            decimal valorPendente,
            decimal valorPercentualCliente)
        {
            ValorEntrada = valorEntrada;
            ValorTema = valorTema;
            ValorComDesconto = valorComDesconto;
            ValorPendente = valorPendente;
            ValorPercentualCliente = valorPercentualCliente;
        }
    }
}
