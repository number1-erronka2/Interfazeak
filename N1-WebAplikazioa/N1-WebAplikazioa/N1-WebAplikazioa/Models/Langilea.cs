using System.ComponentModel.DataAnnotations;

namespace N1_WebAplikazioa.Models;

public class Langilea {
    public string email { get; set; }
    [Key]
    public string erabiltzailea { get; set; }
    public string izena { get; set; }
    public DateTime jaiotzaData { get; set; }
    public int taldea { get; set; }
    
    public Langilea() {
        // empty constructor   
    }
}