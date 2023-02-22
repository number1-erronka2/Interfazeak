using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using N1_WebAplikazioa.Data;
using N1_WebAplikazioa.Models;
using N1_WebAplikazioa.ViewModels;

namespace N1_WebAplikazioa.Controllers; 

public class BalorazioaController {
    private readonly ApplicationDbContext _context;

    public BalorazioaController(ApplicationDbContext context) {
        _context = context;
    }
}