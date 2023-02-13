using N1_WebAplikazioa.Models;

namespace N1_WebAplikazioa.Services;

public interface ILangileaService {
    Task<List<Langilea>> GetLangileak();
    Task<Langilea> GetLangilea(string user);
}