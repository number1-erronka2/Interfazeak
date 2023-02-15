using N1_WebAplikazioa.Models;

namespace N1_WebAplikazioa.Services; 

public interface IPartidaService { 
    Task<List<Partida>> GetPartidak();
    Task<Partida> GetPartida(int id);
    Task<Partida> AddPartida(Partida partida);
    Task<Partida> UpdatePartida(Partida partida);
    Task<Partida> DeletePartida(int id);
}