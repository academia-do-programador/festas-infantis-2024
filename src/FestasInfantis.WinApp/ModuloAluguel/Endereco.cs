namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Endereco
    {
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }

        public Endereco(string estado, string cidade, string bairro, string rua, string numero)
        {
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
        }

        public List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Cidade))
                erros.Add("O campo 'Cidade' é obrigatório!");

            if (string.IsNullOrEmpty(Estado))
                erros.Add("O campo 'Estado' é obrigatório!");

            if (string.IsNullOrEmpty(Rua))
                erros.Add("O campo 'Rua' é obrigatório!");

            if (string.IsNullOrEmpty(Bairro))
                erros.Add("O campo 'Bairro' é obrigatório!");

            if (string.IsNullOrEmpty(Numero))
                erros.Add("O campo 'Número' é obrigatório!");

            return erros;
        }
    }
}
