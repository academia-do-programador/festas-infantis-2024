using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Aluguel : EntidadeBase
    {
        public Festa Festa { get; set; }
        public Cliente Cliente { get; set; }
        public Tema Tema { get; set; }
        public PorcentagemEntradaEnum PorcentagemEntrada { get; set; }
        public ConfiguracaoDesconto Desconto { get; set; }
        public DateTime Abertura { get; set; }
        public DateTime Pagamento { get; private set; }
        public bool Concluido { get; private set; }

        public Aluguel(
         Festa festa,
         Cliente cliente,
         Tema tema,
         PorcentagemEntradaEnum porcentagemEntrada,
         ConfiguracaoDesconto desconto)
        {
            Festa = festa;
            Cliente = cliente;
            Tema = tema;
            PorcentagemEntrada = porcentagemEntrada;
            Desconto = desconto;

            Abertura = DateTime.Now;
            Pagamento = DateTime.MinValue;
            Concluido = false;
        }

        public void Concluir()
        {
            Concluido = true;
            Pagamento = DateTime.Now;
        }

        public DadosPagamentoAluguel ObterDadosPagamento()
        {
            decimal percentualCliente = Cliente.CalcularDesconto(Desconto);

            decimal valorTemaComDesconto = Tema.CalcularValorComDesconto(percentualCliente);

            decimal valorEntrada = valorTemaComDesconto - (valorTemaComDesconto * (decimal)PorcentagemEntrada / 100);

            decimal valorPendente = valorTemaComDesconto - valorEntrada;

            DadosPagamentoAluguel dados = new DadosPagamentoAluguel()
            {
                ValorPercentualCliente = percentualCliente,
                ValorTema = Tema.Valor,
                ValorComDesconto = valorTemaComDesconto,
                ValorEntrada = valorEntrada,
                ValorPendente = valorPendente
            };

            return dados;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (Festa != null)
                erros.AddRange(Festa.Validar());

            if (Cliente == null)
                erros.Add("O campo 'Cliente' é obrigatório");

            if (Tema == null)
                erros.Add("O campo 'Tema' é obrigatório");

            if (PorcentagemEntrada <= 0)
                erros.Add("O campo '% de Entrada' é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Aluguel registroAtualizado = (Aluguel)novoRegistro;

            Festa = registroAtualizado.Festa;
            Cliente = registroAtualizado.Cliente;
            Tema = registroAtualizado.Tema;
            PorcentagemEntrada = registroAtualizado.PorcentagemEntrada;
            Pagamento = registroAtualizado.Pagamento;
            Concluido = registroAtualizado.Concluido;
        }
    }
}
