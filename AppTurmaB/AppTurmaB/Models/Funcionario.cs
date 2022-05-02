using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppTurmaB.Models
{
    public class Funcionario
    {
        [Required(ErrorMessage = "O Campo Codigo é Obrigatório.")]
        [Display(Name = "Código")]
        [Range(1, 666)]
        public int FuncID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Seu nome deve ter entre 1 e 50 caracteres.")]
        public string Nome { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        [Display(Name = "Confirmar Senha")]
        [Compare("Senha")]
        public string ConfSenha { get; set; }
    }
}