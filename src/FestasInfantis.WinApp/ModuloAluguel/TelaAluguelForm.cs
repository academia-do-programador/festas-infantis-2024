﻿using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloConfiguracaoDesconto;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private Aluguel aluguel;
        public Aluguel Aluguel
        {
            get => aluguel;
        }

        public ConfiguracaoDesconto Desconto { get; set; }

        public TelaAluguelForm(List<Cliente> clientesDisponiveis, List<Tema> temasDisponiveis)
        {
            InitializeComponent();

            foreach (Cliente c in clientesDisponiveis)
                cmbClientes.Items.Add(c);

            foreach (Tema t in temasDisponiveis)
                cmbTemas.Items.Add(t);

            Array valoresEnum = Enum.GetValues(typeof(PorcentagemEntradaEnum));

            foreach (object valor in valoresEnum)
                cmbEntrada.Items.Add(valor);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            aluguel = ObterAluguel();

            List<string> erros = aluguel.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (
                cmbClientes.SelectedItem == null ||
                cmbEntrada.SelectedItem == null ||
                cmbTemas.SelectedItem == null)
            {
                MessageBox.Show(
                    "Você precisa preencer os campos: \"Cliente\", \"Entrada\" e \"Tema\"!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            aluguel = ObterAluguel();

            DadosPagamentoAluguel dadosPagamento = aluguel.ObterDadosPagamento();

            txtValorDesconto.Text = dadosPagamento.ValorComDesconto.ToString();
            txtValorSinal.Text = dadosPagamento.ValorEntrada.ToString();
            txtPorcentagemDesconto.Text = dadosPagamento.ValorPercentualCliente.ToString();
            txtValorPendente.Text = dadosPagamento.ValorPendente.ToString();
            txtValorTema.Text = dadosPagamento.ValorTema.ToString();
        }

        private Aluguel ObterAluguel()
        {
            Endereco endereco = new Endereco(
             txtEstado.Text,
             txtCidade.Text,
             txtBairro.Text,
             txtRua.Text,
             txtNumero.Text
            );

            // festa
            Festa festa = new Festa(
              endereco,
              txtDataFesta.Value,
              txtHorarioInicio.Value.TimeOfDay,
              txtHorarioTermino.Value.TimeOfDay
            );

            // aluguel
            PorcentagemEntradaEnum entrada = (PorcentagemEntradaEnum)cmbEntrada.SelectedItem;

            Cliente cliente = (Cliente)cmbClientes.SelectedItem;

            Tema tema = (Tema)cmbTemas.SelectedItem;

            return new Aluguel(festa, cliente, tema, entrada, Desconto);
        }
    }
}