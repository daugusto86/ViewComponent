using System.Collections.Generic;

namespace ViewComponent.App.Notificacoes
{
    public class Notificador : INotificador
    {
        private List<Notificacao> notificacoes;
        public Notificador()
        {
            notificacoes = new List<Notificacao>();
        }

        public void Handle(Notificacao notificacao)
        {
            notificacoes.Add(notificacao);
        }

        public IReadOnlyCollection<Notificacao> ObterNotificacoes()
        {
            return notificacoes.AsReadOnly();
        }

        public void LimparNotificacoes()
        {
            notificacoes.Clear();
        }
    }
}
