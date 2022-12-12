using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TesteMVC5.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        /*[Required(ErrorMessage = existem outros formatos de erros")]*/
        /*DisplayName = Nome do que aparece na View*/
        /*EmailAdress = estrutura de e-mail*/

        [DisplayName("Nome da Empresa")]
        [Required(ErrorMessage = "Por favor, informe o {0}.")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres!")]
        public string NomeEmpresa { get; set; }

        [Required(ErrorMessage = "Por favor, informe o {0}.")]
        [MaxLength(12)]
        public string CNPJ { get; set; }

        [DisplayName("Contato do Financeiro")]
        [Required(ErrorMessage = "Por favor, informe o {0}.")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres!")]
        public string NomeContatoFinanceiro { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Por favor, informe o e-mail.")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres!")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Por favor, informe o {0}.")]
        [MaxLength(11)]
        public string Telefone { get; set; }


        public DateTime DataMatricula { get; set; }

        public bool Ativo { get; set; }


    }
}
