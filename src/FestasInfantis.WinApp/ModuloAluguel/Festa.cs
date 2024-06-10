namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Festa
    {
        public Endereco Endereco { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraTermino { get; set; }

        public Festa(Endereco endereco, DateTime data, TimeSpan horaInicio, TimeSpan horaTermino)
        {
            Endereco = endereco;
            Data = data;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
        }

        public List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (Data < DateTime.Today)
                erros.Add("A data da festa não pode ser no passado!");

            if (HoraInicio == TimeSpan.Zero)
                erros.Add("O horário de início não pode ser 00:00!");

            if (HoraTermino == TimeSpan.Zero)
                erros.Add("O horário de término não pode ser 00:00!");

            if (HoraTermino < HoraInicio)
                erros.Add("O horário de término não pode ser antes do início!");

            if (Endereco != null)
                erros.AddRange(Endereco.Validar());

            return erros;
        }
    }
}
