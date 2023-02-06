using Microsoft.AspNetCore.Mvc;
using WebAplikazioa.Services;

namespace Wineshop.ViewComponents
{
    public class PartidakViewComponent : ViewComponent
    {
        private readonly IPartidaService _partidaService; //Partina honako fitxategixe be bida?
        public PartidakViewComponent(IPartidaService partidaService)
        {
            _partidaService = partidaService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.mota = id;
            return View(await _partidaService.GetPartida(id));
        }
    }
}
