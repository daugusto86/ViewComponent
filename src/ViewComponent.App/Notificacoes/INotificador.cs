using System.Collections.Generic;

namespace ViewComponent.App.Notificacoes
{
    public interface INotificador
    {
        void Handle(Notificacao notificacao);
        IReadOnlyCollection<Notificacao> ObterNotificacoes();
        void LimparNotificacoes();
    }
}
