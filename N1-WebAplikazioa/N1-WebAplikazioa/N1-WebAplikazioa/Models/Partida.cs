using System.ComponentModel.DataAnnotations;

namespace N1_WebAplikazioa.Models;

public class Partida {
    [Key]
    public int id { get; set; }
    public DateTime data { get; set; }
    public string jokoIzena { get; set; }
    public Langilea langilea { get; set; }
    public int puntuazioa { get; set; }

    public Partida() {
        // empty constructor
    }
}