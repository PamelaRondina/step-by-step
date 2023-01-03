using Pam.AppMvc.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Pam.AppMvc.ViewModels
{
    /*Aqui temos uma representação da entidade Produto, representa as mesmas catacterísticas*/
    public class ProdutoViewModel
    { 
    public ProdutoViewModel()
    {
        Id = Guid.NewGuid();
    }

    /*Campo Id é a Chave*/
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [DisplayName("Fornecedor")]
    public Guid FornecedorId { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
    public string Nome { get; set; }

    [DisplayName("Descrição")]
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
    public string Descricao { get; set; }

    ///*Nome da imagem no BD*/
    [DisplayName("Imagem do Produto")]
    public HttpPostedFileBase ImagemUpload { get; set; }
    
    public string Imagem { get; set; }

    [Moeda]
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public decimal Valor { get; set; }

    [ScaffoldColumn(false)]
    public DateTime DataCadastro { get; set; }

    [DisplayName("Ativo?")]
    public bool Ativo { get; set; }

    ///*Fornecedor que representa o produto*/
    public FornecedorViewModel Fornecedor { get; set; }

    ///*Lista de Fornecedores que auxilia a escrever o DropDownList*/
    public IEnumerable<FornecedorViewModel> Fornecedores { get; set; }
    
    }

}
