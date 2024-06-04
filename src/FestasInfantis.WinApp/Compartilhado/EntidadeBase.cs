﻿namespace eAgenda.ConsoleApp.Compartilhado
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }

        public abstract void AtualizarRegistro(EntidadeBase novoRegistro);
        public abstract List<string> Validar();

        #region Auxiliares de validação
        protected void VerificaNulo(ref List<string> erros, string campoTestado, string mostraCampo)
        {
            if (string.IsNullOrEmpty(campoTestado))
                erros.Add($"\nO campo \"{mostraCampo}\" é obrigatório. Tente novamente ");
        }
        protected void VerificaNulo(ref List<string> erros, int campoTestado, string mostraCampo)
        {
            if (string.IsNullOrEmpty(campoTestado.ToString()))
                erros.Add($"\nO campo \"{mostraCampo}\" é obrigatório. Tente novamente ");
        }
        #endregion
    }
}
