using System.Collections.Generic;


namespace Pam.Business.Core.Notificacoes
{
    public interface INotificador
    {
        /*método de teste para saber se tem notificação*/
        bool TemNotificacao();
        /*retorna uma lista das notificações*/
        List<Notificacao> ObterNotificacoes();
        /*Handle = manipular quando uma notificação é lançada*/
        void Handle(Notificacao notificacao);
    }
}
