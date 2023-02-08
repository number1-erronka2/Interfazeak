using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using WebAplikazioa.Models;
using WebAplikazioa.Services;

namespace WebAplikazioa.Controllers
{
    
    public class HomeController : Controller
    {

        //http://192.168.65.123:8989/swagger-ui/index.html#/ REST APIA
        //public static int a=1;




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
        //public IActionResult Jokoa(int z)




        //public static int a;
        [Route("Home/Jokoa/{z}")]
        public async Task<IActionResult> Jokoa(int z)
        {
            //a = z;
            ViewData["zenbaki"] = z;

            //return View(Jokoa(z)); //bialdu a aldagaixe be. Return barrun bi aldagai
            return View(Jokoa);
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