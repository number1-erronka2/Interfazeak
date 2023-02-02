using WebAplikazioa.Models;

namespace WebAplikazioa.Services
{
    public interface IPartidaService
    {
        //Task<IList<ArdoaUpeltegi>> GetMota(int id);
        Task<List<PartidaModel>> GetPartidak();
        Task<List<PartidaModel>> GetPartidaOnenak(int zenbat);
        Task<PartidaModel> GetPartida(int id);
    }
}
