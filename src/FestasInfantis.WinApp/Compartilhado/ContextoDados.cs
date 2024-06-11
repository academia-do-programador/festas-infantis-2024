using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.Compartilhado
{
    public class ContextoDados
    {
        private string caminho = $"C:\\temp\\FestasInfantis\\dados.json";

        public List<Cliente> Clientes { get; set; }
        public List<Item> Itens { get; set; }
        public List<Tema> Temas { get; set; }

        public ContextoDados()
        {
            Clientes = new List<Cliente>();
            Itens = new List<Item>();
            Temas = new List<Tema>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarDados();
        }

        public void Gravar()
        {
            FileInfo arquivo = new FileInfo(caminho);

            arquivo.Serializar(this, preservarReferencias: true);
        }

        protected void CarregarDados()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return;

            ContextoDados ctx = arquivo.Deserializar<ContextoDados>(preservarReferencias: true);

            if (ctx == null)
                return;

            Clientes = ctx.Clientes;
            Itens = ctx.Itens;
            Temas = ctx.Temas;
        }
    }
}
