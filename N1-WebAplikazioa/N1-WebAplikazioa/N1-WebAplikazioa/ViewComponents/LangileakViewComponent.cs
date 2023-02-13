using Microsoft.AspNetCore.Mvc;
using N1_WebAplikazioa.Services;

namespace N1_WebAplikazioa.ViewComponents; 

public class LangileakViewComponent : ViewComponent {
    private readonly ILangileaService _langileaService;
    public LangileakViewComponent(ILangileaService langileaService) {
        _langileaService = langileaService;
    }
    /*
     //errore bat ematen du
    public async Task<IViewComponentResult> InvokeAsync(int id) {
        return View(await _langileaService.GetLangileak());
    }
    */
}