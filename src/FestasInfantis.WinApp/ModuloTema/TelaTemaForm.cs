
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private Tema tema;
        public Tema Tema
        {
            get { return tema; }
        }

        public List<Item> ItensMarcados
        {
            get
            {
                return listItens
                    .CheckedItems
                    .Cast<Item>()
                    .ToList();
            }
        }

        public TelaTemaForm()
        {
            InitializeComponent();
        }

        public void CarregarItens(List<Item> itens)
        {
            foreach (Item it in itens)
                listItens.Items.Add(it);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            tema = new Tema(nome);

            List<string> erros = tema.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
