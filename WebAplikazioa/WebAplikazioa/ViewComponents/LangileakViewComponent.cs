using Microsoft.AspNetCore.Mvc;
using WebAplikazioa.Services;

namespace Wineshop.ViewComponents
{
    public class LangileakViewComponent : ViewComponent
    {
        private readonly ILangileaService _langileaService; //Partina honako fitxategixe be bida?
        public LangileakViewComponent(ILangileaService langileaService)
        {
            _langileaService = langileaService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.mota = id;
            return View(await _langileaService.GetLangilea(id));
        }
    }
}
