using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Nome { get; set; }

        public List<Item> Itens { get; set; } = new List<Item>();

        public decimal Valor
        {
            get
            {
                decimal valor = 0;

                foreach (Item i in Itens)
                    valor += i.Valor;

                return valor;
            }
        }

        public Tema() { }

        public Tema(string nome)
        {
            Nome = nome;
        }

        public bool AdicionarItem(Item item)
        {
            if (Itens.Contains(item))
                return false;

            Itens.Add(item);

            item.AtribuirTema(this);

            return true;
        }

        public bool RemoverItem(Item item)
        {
            if (!Itens.Contains(item))
                return false;

            Itens.Remove(item);

            item.RemoverTema();

            return true;
        }

        public decimal CalcularValorComDesconto(decimal percentualCliente)
        {
            return Valor - (Valor * percentualCliente / 100);
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema tema = (Tema)novoRegistro;

            Nome = tema.Nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"Nome\" é obrigatório");

            return erros;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
