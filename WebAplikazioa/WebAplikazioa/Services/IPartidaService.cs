using WebAplikazioa.Models;
using WebAplikazioa.ViewModels;

namespace WebAplikazioa.Services
{
    public interface IPartidaService
    {
        //Task<IList<ArdoaUpeltegi>> GetMota(int id);






        Task<List<PartidaModel>> GetPartidak();
        Task<List<PartidaAleaViewModel>> GetPartidak2();



        Task<List<PartidaModel>> GetPartidaOnenak();
        Task<PartidaModel> GetPartida(int id);
    }
}
