using Microsoft.AspNetCore.Mvc;
using N1_WebAplikazioa.Models;
using N1_WebAplikazioa.Services;
using N1_WebAplikazioa.ViewModels;
using Newtonsoft.Json;

namespace N1_WebAplikazioa.Controllers;

public class RankingController : Controller {
    private readonly IPartidaService _partidaService;

    public RankingController(IPartidaService partidaService) {
        _partidaService = partidaService;
    }

    public async Task<ActionResult> Index() {
        var partidaVM = new PartidaViewModel();
        List<Partida> partidaGuztiak = new List<Partida>();
        partidaGuztiak = await _partidaService.GetPartidak();
        partidaVM.PartidaVMList = partidaGuztiak;
        partidaGuztiak.Sort((x, y) => y.puntuazioa.CompareTo(x.puntuazioa));
        return View(partidaVM);
    }
}