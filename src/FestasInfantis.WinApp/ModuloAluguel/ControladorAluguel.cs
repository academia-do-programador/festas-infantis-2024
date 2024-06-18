﻿using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloConfiguracaoDesconto;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        TabelaAluguelControl tabelaAluguel;

        IRepositorioConfiguracaoDesconto repositorioDesconto;
        IRepositorioCliente repositorioCliente;
        IRepositorioTema repositorioTema;
        IRepositorioAluguel repositorioAluguel;

        public ControladorAluguel(
            IRepositorioConfiguracaoDesconto repositorioDesconto,
            IRepositorioCliente repositorioCliente,
            IRepositorioTema repositorioTema,
            IRepositorioAluguel repositorioAluguel)
        {
            this.repositorioDesconto = repositorioDesconto;
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
            this.repositorioAluguel = repositorioAluguel;
        }

        public override string TipoCadastro { get { return "Aluguéis"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo Aluguel"; } }

        public override string ToolTipEditar { get { return "Editar um Aluguel existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um Aluguel existente"; } }

        public override void Adicionar()
        {
            List<Cliente> clientesDisponiveis = repositorioCliente.SelecionarTodos();
            List<Tema> temasDisponiveis = repositorioTema.SelecionarTodos();

            ConfiguracaoDesconto descontoAtual = repositorioDesconto.ObterConfiguracao();

            TelaAluguelForm telaAluguel =
                new TelaAluguelForm(clientesDisponiveis, temasDisponiveis);

            telaAluguel.Desconto = descontoAtual;

            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Aluguel novoAluguel = telaAluguel.Aluguel;

            repositorioAluguel.Cadastrar(novoAluguel);

            CarregarAlugueis();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O aluguel em nome de \"{novoAluguel.Cliente.Nome}\" foi criado com sucesso!");
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
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarAlugueis();

            return tabelaAluguel;
        }

        public void CarregarAlugueis()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);
        }
    }
}