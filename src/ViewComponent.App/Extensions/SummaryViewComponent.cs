using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ViewComponent.App.Notificacoes;

namespace ViewComponent.App.Extensions
{
    public class SummaryViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private readonly INotificador notificador;

        public SummaryViewComponent(INotificador notificador)
        {
            this.notificador = notificador;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notificacoes = await Task.FromResult(notificador.ObterNotificacoes());
            return View(notificacoes);
        }
    }
}
