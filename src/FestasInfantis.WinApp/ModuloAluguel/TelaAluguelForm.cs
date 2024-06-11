using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        private Aluguel aluguel;

        public Aluguel Aluguel
        {
            get => aluguel;
            set
            {
                txtId.Text = value.Id.ToString();

                txtDataFesta.Value = value.Festa.Data;
                txtHorarioInicio.Value = value.Festa.Data + value.Festa.HoraInicio;
                txtHorarioTermino.Value = value.Festa.Data + value.Festa.HoraTermino;

                txtEstado.Text = value.Festa.Endereco.Estado;
                txtCidade.Text = value.Festa.Endereco.Cidade;
                txtBairro.Text = value.Festa.Endereco.Bairro;
                txtRua.Text = value.Festa.Endereco.Rua;
                txtNumero.Text = value.Festa.Endereco.Numero;

                cmbClientes.SelectedItem = value.Cliente;
                cmbTemas.SelectedItem = value.Tema;
                cmbEntrada.SelectedItem = value.PorcentagemEntrada;

                aluguel = ObterAluguel();

                CarregarDadosPagamento(aluguel.ObterDadosPagamento());
            }
        }

        public ConfiguracaoDesconto Desconto { get; set; }

        public TelaAluguelForm(List<Cliente> clientesDisponiveis, List<Tema> temasDisponiveis)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarClientes(clientesDisponiveis);
            CarregarTemas(temasDisponiveis);
            CarregarOpcoesDeEntrada();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (aluguel == null)
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
                    "Você precisa selecionar os campos: \"Cliente\", \"Entrada\" e \"Tema\"!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            aluguel = ObterAluguel();

            CarregarDadosPagamento(aluguel.ObterDadosPagamento());
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

            Festa festa = new Festa(
                endereco,
                txtDataFesta.Value,
                txtHorarioInicio.Value.TimeOfDay,
                txtHorarioTermino.Value.TimeOfDay
            );

            PorcentagemEntradaEnum entrada = (PorcentagemEntradaEnum)cmbEntrada.SelectedItem;

            Cliente cliente = (Cliente)cmbClientes.SelectedItem;

            Tema tema = (Tema)cmbTemas.SelectedItem;

            return new Aluguel(festa, cliente, tema, entrada, Desconto);
        }

        private void CarregarDadosPagamento(DadosPagamentoAluguel dadosPagamento)
        {
            txtValorDesconto.Text = dadosPagamento.ValorComDesconto.ToString();
            txtValorSinal.Text = dadosPagamento.ValorEntrada.ToString();
            txtPorcentagemDesconto.Text = dadosPagamento.ValorPercentualCliente.ToString();
            txtValorPendente.Text = dadosPagamento.ValorPendente.ToString();
            txtValorTema.Text = dadosPagamento.ValorTema.ToString();
        }

        private void CarregarClientes(List<Cliente> clientesDisponiveis)
        {
            foreach (Cliente c in clientesDisponiveis)
                cmbClientes.Items.Add(c);
        }

        private void CarregarTemas(List<Tema> temasDisponiveis)
        {
            foreach (Tema t in temasDisponiveis)
                cmbTemas.Items.Add(t);
        }

        private void CarregarOpcoesDeEntrada()
        {
            Array valoresEnum = Enum.GetValues(typeof(PorcentagemEntradaEnum));

            foreach (object valor in valoresEnum)
                cmbEntrada.Items.Add(valor);
        }
    }
}
