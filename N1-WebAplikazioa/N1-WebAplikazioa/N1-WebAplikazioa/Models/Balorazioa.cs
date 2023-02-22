namespace N1_WebAplikazioa.Models; 

public class Balorazioa {
    public string erabiltzailea { get; set; }
    public string jokoa { get; set; }
    public int puntuazioa { get; set; }
    public string komentarioa { get; set; }
    
    public Balorazioa() {
        // empty constructor
    }
}