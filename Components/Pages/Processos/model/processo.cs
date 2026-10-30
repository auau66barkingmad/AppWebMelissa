using System;
using System.ComponentModel.DataAnnotations;

namespace AppWebMelissa.Model
{
    public class Processo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o número do processo.")]
        public string Numero { get; set; } = string.Empty;

        public DateTime? Data { get; set; }

        [Required(ErrorMessage = "Informe o interessado.")]
        public string Interessado { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o assunto.")]
        public string Assunto { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "Selecione a situação.")]
        public string Situacao { get; set; } = "Aberto";
    }
}