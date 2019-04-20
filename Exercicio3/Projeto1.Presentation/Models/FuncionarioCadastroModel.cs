using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto1.Presentation.Models
{
    public class FuncionarioCadastroModel
    {
        [RegularExpression("^[A-Za-zÀ-Üà-ü0-9\\s]{6,150}$", ErrorMessage = "Por favor, informe um nome válido")]//permissao de caracteres para criação do texto
        [Required(ErrorMessage = "Por Favor, informe o nome do Funcionário!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Por Favor, informe o salário do Funcionário!")]
        public decimal Salario { get; set; }
        [Required(ErrorMessage = "Por Favor, informe a data de admissão do Funcionário!")]
        public DateTime DataAdmissao { get; set; }

    }
}