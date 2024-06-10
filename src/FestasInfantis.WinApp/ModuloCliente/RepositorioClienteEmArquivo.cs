using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class RepositorioClienteEmArquivo : RepositorioBaseEmArquivo<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Cliente> ObterRegistros()
        {
            return contexto.Clientes;
        }
    }
}
