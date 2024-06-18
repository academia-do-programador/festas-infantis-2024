using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class RepositorioAluguelEmArquivo : RepositorioBaseEmArquivo<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contexto.Alugueis;
        }
    }
}
