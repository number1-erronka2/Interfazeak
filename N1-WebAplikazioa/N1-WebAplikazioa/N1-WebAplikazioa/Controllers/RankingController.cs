using Microsoft.AspNetCore.Mvc;

namespace N1_WebAplikazioa.Controllers; 

public class RankingController : Controller {
    public IActionResult Index() {
        return View("~/Views/Ranking/Index.cshtml");
    }
}