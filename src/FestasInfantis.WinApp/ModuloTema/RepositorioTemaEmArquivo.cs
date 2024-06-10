using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    internal class RepositorioTemaEmArquivo : RepositorioBaseEmArquivo<Tema>, IRepositorioTema
    {
        public RepositorioTemaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Tema> ObterRegistros()
        {
            return contexto.Temas;
        }

        public override bool Excluir(int id)
        {
            Tema tema = SelecionarPorId(id);

            if (tema.Itens.Any())
            {
                foreach (Item i in tema.Itens)
                    i.RemoverTema();
            }

            return base.Excluir(id);
        }

        public void AdicionarItens(Tema temaSelecionado, List<Item> itens)
        {
            foreach (Item item in itens)
                temaSelecionado.AdicionarItem(item);

            contexto.Gravar();
        }

        public void AtualizarItens(Tema temaSelecionado, List<Item> itensDesmarcados, List<Item> itensMarcados)
        {
            foreach (Item i in itensDesmarcados)
            {
                if (temaSelecionado.Itens.Contains(i))
                    temaSelecionado.RemoverItem(i);
            }

            foreach (Item i in itensMarcados)
            {
                if (!temaSelecionado.Itens.Contains(i))
                    temaSelecionado.AdicionarItem(i);
            }

            contexto.Gravar();
        }
    }
}
