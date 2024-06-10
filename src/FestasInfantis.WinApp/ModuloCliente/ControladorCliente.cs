﻿using eAgenda.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        TabelaClienteControl tabelaCliente;
        IRepositorioCliente repositorioCliente;

        public override string TipoCadastro { get { return "Clientes"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo cliente"; } }

        public override string ToolTipEditar { get { return "Editar um cliente existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um cliente existente"; } }

        public ControladorCliente(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public override void Adicionar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            DialogResult resultado = telaCliente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Cliente novoCliente = telaCliente.Cliente;

            repositorioCliente.Cadastrar(novoCliente);

            CarregarClientes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoCliente.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            int idSelecionado = tabelaCliente.ObterRegistroSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(idSelecionado);

            if (clienteSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possivel realizar esta ação sem selecionar algo",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            TelaClienteForm telaCliente = new TelaClienteForm();

            telaCliente.Cliente = clienteSelecionado;

            DialogResult resultado = telaCliente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Cliente clienteEditado = telaCliente.Cliente;

            repositorioCliente.Editar(idSelecionado, clienteEditado);

            CarregarClientes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{clienteEditado.Nome}\" foi criado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaCliente.ObterRegistroSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(idSelecionado);

            if (clienteSelecionado == null)
            {
                MessageBox.Show(
                     "Não é possível realizar esta ação sem um registro selecionado.",
                     "Aviso",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                     );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{clienteSelecionado.Nome}\" ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resposta != DialogResult.Yes)
                return;

            repositorioCliente.Excluir(clienteSelecionado.Id);

            CarregarClientes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{clienteSelecionado.Nome}\" foi criado com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

            CarregarClientes();

            return tabelaCliente;
        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(clientes);
        }
    }
}
