using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using N1_WebAplikazioa.Models;

namespace N1_WebAplikazioa.Controllers;

public class HomeController : Controller {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) {
        _logger = logger;
    }

    //honek dokumentaziñoien agertzeko komentarixuk
    /// <summary>
    /// Index bueltau
    /// </summary>
    /// <returns></returns>
    public IActionResult Index() {
        return View();
    }

    public IActionResult Privacy() {
        return View();
    }
    
    //dokumentaziñoie agertzeko komanduk (visual studioko terminalin eitteku)
    //cd DokuWineShop
    //docfx serve _site -p 8081

    /// <summary>
    /// Jokalari onenak bueltau
    /// </summary>
    /// <returns></returns>
    public async Task<IActionResult> Jokalari_onenak()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}