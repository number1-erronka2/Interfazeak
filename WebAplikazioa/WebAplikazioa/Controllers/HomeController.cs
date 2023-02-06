using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAplikazioa.Models;
using WebAplikazioa.Services;

namespace WebAplikazioa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IPartidaService _partidaService;

        //public HomeController(ILogger<HomeController> logger, IPartidaService jokoaService)
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_partidaService = jokoaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Jokoak()
        {
            return View();
        }

        //jokun zenbakixe pasau. Gero datu basigaz konektau
        //datu basigaz hemen konektau edo "jokoa" barrun?
        public IActionResult Jokoa(int z)
        {
            switch (z) //web orri bat zabaldu eta z arabera eduki ezberdiñe
            {
                case 1:
                    return View(Jokoa);
                case 2:
                    return View(Jokoa);
                case 3:
                    return View(Jokoa);
                case 4:
                    return View(Jokoa);
                default:
                    return View(); //
            }
            //return View();
        }

        //jokuntzako eta jokalarixentzako model eta service desberdiñek
        
        //joko bakoitzeko rankinga eta jokalari onenak

        public async Task<IActionResult> Jokalari_onenak() //model hartzeko. Partida a
        {
            return View();
            /*List<PartidaModel> jokalariOnenakList = new List<PartidaModel>();
            jokalariOnenakList = await _partidaService.GetPartidaOnenak();
            return View(jokalariOnenakList);
            
            
            //danak bueltaukozkuz
            //beste metodo bat sortubikoda?*/
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}