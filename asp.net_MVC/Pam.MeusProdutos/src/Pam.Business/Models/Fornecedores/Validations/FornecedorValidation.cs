using FluentValidation;
using Pam.Business.Core.Validations.Documentos;

namespace Pam.Business.Models.Fornecedores.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation() 
        {
            RuleFor(f => f.Nome)
                /*Não pode ser vazio | Com mensagem*/
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido.")
                /*Tamanho do Nome 2 = mínimo e 100 = máximo*/
                .Length(2,200).WithMessage("O campo {propertyName} precisa ter entre {MinLength} e {MaxLength} caracteres.");

            /*Validar CPF ou CNPJ*/
            When(f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CpfValidacao.TamanhoCpf)
                .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");
                RuleFor(f => CpfValidacao.Validar(f.Documento)).Equal(true)
                .WithMessage("O documento forneceido é inválido.");
            });

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CnpjValidacao.TamanhoCnpj)
                .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");
                RuleFor(f => CnpjValidacao.Validar(f.Documento)).Equal(true)
                .WithMessage("O documento forneceido é inválido.");

            });
        }
    }
}
