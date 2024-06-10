using eAgenda.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class ControladorItem : ControladorBase
    {
        IRepositorioItem repositorioItem;
        TabelaItemControl tabelaItem;

        public override string TipoCadastro => "Item";

        public override string ToolTipAdicionar => "Cadastrar um novo Item";

        public override string ToolTipEditar => "Editar um item existente";

        public override string ToolTipExcluir => "Excluir um item existente";

        public ControladorItem(IRepositorioItem repositorioItem)
        {
            this.repositorioItem = repositorioItem;
        }

        public override void Adicionar()
        {
            TelaItemForm telaItem = new TelaItemForm();

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Item novoItem = telaItem.Item;

            repositorioItem.Cadastrar(novoItem);

            CarregarItens();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoItem.Descricao}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            Item itemSelecionado = repositorioItem.SelecionarPorId(tabelaItem.ObterRegistroSelecionado());

            if (itemSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            TelaItemForm telaItem = new TelaItemForm();

            telaItem.Item = itemSelecionado;

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Item itemEditado = telaItem.Item;

            repositorioItem.Editar(itemSelecionado.Id, itemEditado);

            CarregarItens();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{itemSelecionado.Descricao}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            Item itemSelecionado = repositorioItem.SelecionarPorId(tabelaItem.ObterRegistroSelecionado());

            if (itemSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta =
                MessageBox.Show(
                    $"Você deseja realmente excluir o registro \"{itemSelecionado.Descricao}\"?",
                    "Confirmar Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
                return;

            repositorioItem.Excluir(itemSelecionado.Id);

            CarregarItens();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{itemSelecionado.Descricao}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaItem == null)
                tabelaItem = new TabelaItemControl();

            CarregarItens();

            return tabelaItem;
        }

        private void CarregarItens()
        {
            List<Item> itens = repositorioItem.SelecionarTodos();

            tabelaItem.AtualizarRegistros(itens);
        }
    }
}
