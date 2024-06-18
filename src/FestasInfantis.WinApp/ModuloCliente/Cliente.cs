using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloConfiguracaoDesconto;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

        public List<Aluguel> Alugueis { get; set; }

        public int QuantidadeAlugueisConcluidos => Alugueis.Count(a => a.Concluido);

        public Cliente()
        {
            Alugueis = new List<Aluguel>();
        }

        public Cliente(string nome, string telefone, string cpf) : this()
        {
            Nome = nome;
            Telefone = telefone;
            Cpf = cpf;
        }

        public decimal CalcularDesconto(ConfiguracaoDesconto configuracaoDesconto)
        {
            decimal desconto = QuantidadeAlugueisConcluidos * configuracaoDesconto.PorcentagemPorAluguel;

            if (desconto > configuracaoDesconto.PorcentagemMaxima)
                desconto = configuracaoDesconto.PorcentagemMaxima;

            return desconto;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(Telefone.Trim()))
                erros.Add("O campo \"telefone\" é obrigatório");

            if (Telefone.Trim().Length < 12)
                erros.Add("O campo \"telefone\" não foi preenchido corretamente");

            if (string.IsNullOrEmpty(Cpf.Trim()))
                erros.Add("O campo \"CPF\" é obrigatório");

            if (Cpf.Trim().Length < 14)
                erros.Add("O campo \"CPF\" não foi preenchido corretamente");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Cliente c = (Cliente)novoRegistro;

            Nome = c.Nome;
            Telefone = c.Telefone;
            Cpf = c.Cpf;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
