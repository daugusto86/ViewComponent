namespace ViewComponent.App.Notificacoes
{
    public class Notificacao
    {
        public TipoNotificacao Tipo { get; }
        public string Mensagem { get; }

        public Notificacao(TipoNotificacao tipo, string mensagem)
        {
            Tipo = tipo;
            Mensagem = mensagem;
        }
    }
}
