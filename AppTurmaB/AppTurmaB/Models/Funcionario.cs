using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+&lt;(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})&gt;$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy", ApplyFormatInEditMode = true)]

        public DateTime DataNasc { get; set; }

        [Required]
        [Remote ("ValidaLogin", "Funcionario", ErrorMessage = "O login já existe.")]
        public string Login { get; set; }

        [Required]
        [RegularExpression(@"[a-zA-Z]{5,10}")]
        public string Senha { get; set; }

        [Required]
        [Display(Name = "Confirmar Senha")]
        [System.ComponentModel.DataAnnotations.Compare("Senha")]
        public string ConfSenha { get; set; }
    }
}