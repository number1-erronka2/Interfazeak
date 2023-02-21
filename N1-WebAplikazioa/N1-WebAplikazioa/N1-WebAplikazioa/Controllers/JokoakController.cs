using Microsoft.AspNetCore.Mvc;

namespace N1_WebAplikazioa.Controllers; 

public class JokoakController : Controller { 
    public IActionResult Index() { 
        return View(); 
    }
}