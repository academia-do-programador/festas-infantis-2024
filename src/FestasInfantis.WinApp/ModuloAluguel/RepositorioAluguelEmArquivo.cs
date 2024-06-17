using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class RepositorioAluguelEmArquivo : RepositorioBaseEmArquivo<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public void ConcluirAluguel(Aluguel aluguel)
        {
            aluguel.Concluir();

            contexto.Gravar();
        }

        public List<Aluguel> SelecionarAlugueisConcluidos()
        {
            return ObterRegistros()
                .Where(a => a.Concluido)
                .ToList();
        }

        public List<Aluguel> SelecionarAlugueisPendentes()
        {
            return ObterRegistros()
                .Where(a => !a.Concluido)
                .ToList();
        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contexto.Alugueis;
        }
    }
}
