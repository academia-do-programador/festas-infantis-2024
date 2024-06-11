
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private Tema tema;
        public Tema Tema
        {
            get { return tema; }
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;

                int contadorItensSelecionados = 0;

                for (int i = 0; i < listItens.Items.Count; i++)
                {
                    Item item = (Item)listItens.Items[i];

                    if (value.Itens.Contains(item))
                        listItens.SetItemChecked(contadorItensSelecionados, true);

                    contadorItensSelecionados++;
                }
            }
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

        public List<Item> ItensDesmarcados
        {
            get
            {
                return listItens
                    .Items
                    .Cast<Item>()
                    .Except(ItensMarcados)
                    .ToList();
            }
        }

        public TelaTemaForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
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
