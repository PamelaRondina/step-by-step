using System.Collections.Generic;
using System.Linq;


namespace Pam.Business.Core.Notificacoes
{
    public class Notificador : INotificador
    {

        private List<Notificacao> _notificacoes;

        public Notificador()
        {
            /*As notificações = uma nova instância*/
            _notificacoes = new List<Notificacao>();
        }
        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public bool TemNotificacao()
        {
            return _notificacoes.Any();
          
        }
    }
}
