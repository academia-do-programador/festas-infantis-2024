using eAgenda.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            grid.Rows.Clear();

            foreach (Aluguel a in alugueis)
            {
                string conclusao = a.Concluido ? a.Pagamento.ToShortDateString() : "Pendente";

                grid.Rows.Add(a.Id, a.Cliente.Nome, a.Tema.Nome, a.Abertura.ToShortDateString(), conclusao);
            }
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Cliente"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Tema", HeaderText = "Tema" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Abertura", HeaderText = "Abertura" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Conclusao", HeaderText = "Conclusão" },
            };
        }
    }
}
