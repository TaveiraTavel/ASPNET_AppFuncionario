using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppTurmaB.Models
{
    public class Funcionario
    {
        [Required(ErrorMessage = "O Campo Codigo é Obrigatório")]
        public int FuncID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Genero { get; set; }
    }
}