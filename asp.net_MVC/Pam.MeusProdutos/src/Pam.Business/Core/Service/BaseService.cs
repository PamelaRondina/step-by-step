using FluentValidation;
using FluentValidation.Results;
using Pam.Business.Core.Models;
using Pam.Business.Core.Notificacoes;

namespace Pam.Business.Core.Service
{
   public abstract class BaseService
    {
        private readonly INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                /*o que fazer com cada erro que encontrar?*/
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }

        /*método que executa qualquer validação de qualquer entidade*/   
        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV: AbstractValidator<TE> where TE : Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }
    }
}
