using Microsoft.AspNetCore.Mvc;
using ViewComponent.App.Notificacoes;

namespace ViewComponent.App.Controllers
{
    public class MensagensController : Controller
    {
        private readonly INotificador notificador;

        public MensagensController(INotificador notificador)
        {
            this.notificador = notificador;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sucesso()
        {
            var notificacao = new Notificacao(TipoNotificacao.Success, "Mensagem de sucesso!!!");
            notificador.Handle(notificacao);

            return View("index");
        }

        public IActionResult Info()
        {
            var notificacao = new Notificacao(TipoNotificacao.Info, "Mensagem informativa!!!");
            notificador.Handle(notificacao);

            return View("Index");
        }

        public IActionResult Alerta()
        {
            var notificacao = new Notificacao(TipoNotificacao.Warning, "Mensagem de alerta!!!");
            notificador.Handle(notificacao);

            return View("Index");
        }

        public IActionResult Erro()
        {
            var notificacao = new Notificacao(TipoNotificacao.Error, "Mensagem de erro!!!");
            notificador.Handle(notificacao);

            return View("Index");
        }

        public IActionResult Todas()
        {
            var sucesso = new Notificacao(TipoNotificacao.Success, "Mensagem de sucesso!!!");
            notificador.Handle(sucesso);

            var info = new Notificacao(TipoNotificacao.Info, "Mensagem informativa!!!");
            notificador.Handle(info);

            var alerta = new Notificacao(TipoNotificacao.Warning, "Mensagem de alerta!!!");
            notificador.Handle(alerta);

            var erro = new Notificacao(TipoNotificacao.Error, "Mensagem de erro!!!");
            notificador.Handle(erro);

            return View("Index");
        }
    }
}
