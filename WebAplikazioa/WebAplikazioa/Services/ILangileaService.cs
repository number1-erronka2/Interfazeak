using WebAplikazioa.Models;

namespace WebAplikazioa.Services
{
    public interface ILangileaService
    {
        //Task<IList<ArdoaUpeltegi>> GetMota(int id);
        Task<List<LangileaModel>> GetLangileak();
        Task<LangileaModel> GetLangilea(string user);
    }
}
