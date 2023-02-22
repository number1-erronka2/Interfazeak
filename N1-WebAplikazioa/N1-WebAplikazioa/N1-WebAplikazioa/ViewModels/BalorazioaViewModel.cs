using N1_WebAplikazioa.Models;

namespace N1_WebAplikazioa.ViewModels; 

public class BalorazioaViewModel {
    public IList<Balorazioa> JokoGuztienBalorazioak { get; set; }
    public IList<Balorazioa> MahiKingdomBalorazioak { get; set; }
    public IList<Balorazioa> ZombieKillerBalorazioak { get; set; }
    public IList<Balorazioa> PouniBalorazioak { get; set; }
    public IList<Balorazioa> JohnnyBalorazioak { get; set; }
}