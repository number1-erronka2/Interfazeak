using N1_WebAplikazioa.Models;

namespace N1_WebAplikazioa.Services; 

public class LangileaService : ILangileaService {
    private Uri baseUri = new Uri("http://192.168.65.123:8989/langileak/allLangilea");
    public Task<List<Langilea>> GetLangileak() {
        throw new NotImplementedException();
    }

    public Task<Langilea> GetLangilea(string user) {
        throw new NotImplementedException();
    }
}