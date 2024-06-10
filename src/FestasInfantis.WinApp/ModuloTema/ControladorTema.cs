using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        public override string TipoCadastro => "Tema";

        public override string ToolTipAdicionar => "Cadastrar um novo tema";

        public override string ToolTipEditar => "Editar um tema existente";

        public override string ToolTipExcluir => "Excluir um tema existente";

        TabelaTemaControl tabelaTema;

        IRepositorioTema repositorioTema;
        IRepositorioItem repositorioItem;

        public ControladorTema(IRepositorioTema repoTema, IRepositorioItem repoItem)
        {
            repositorioTema = repoTema;
            repositorioItem = repoItem;
        }

        public override void Adicionar()
        {
            TelaTemaForm telaTema = new TelaTemaForm();

            List<Item> itensDisponiveis = repositorioItem.SelecionarItensDisponiveis();

            telaTema.CarregarItens(itensDisponiveis);

            DialogResult resultado = telaTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Tema novoTema = telaTema.Tema;

            repositorioTema.Cadastrar(novoTema);

            repositorioTema.AdicionarItens(novoTema, telaTema.ItensMarcados);

            CarregarTemas();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoTema.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTema == null)
                tabelaTema = new TabelaTemaControl();

            CarregarTemas();

            return tabelaTema;
        }

        private void CarregarTemas()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();

            tabelaTema.AtualizarRegistros(temas);
        }
    }
}
