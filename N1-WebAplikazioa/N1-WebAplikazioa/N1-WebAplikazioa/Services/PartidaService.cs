using System.Text;
using Newtonsoft.Json;
using N1_WebAplikazioa.Models;

namespace N1_WebAplikazioa.Services; 

public class PartidaService {
    private Uri baseUri = new Uri("https://192.168.65.123/partidak/allPartida");
    
    public async Task<List<Partida>> GetPartidak() {
        List<Partida> partidaList = new List<Partida>();
        using (var httpClient = new HttpClient()) {
            using (var response = await httpClient.GetAsync(baseUri)) {
                string apiResponse = await response.Content.ReadAsStringAsync();
                partidaList = JsonConvert.DeserializeObject<List<Partida>>(apiResponse);
            }
        }
        return partidaList;
    }
    
    public async Task<Partida> GetPartida(int id) {
        Partida partida = new Partida();
        using (var httpClient = new HttpClient()) {
            using (var response = await httpClient.GetAsync(baseUri + "/" + id)) {
                string apiResponse = await response.Content.ReadAsStringAsync();
                partida = JsonConvert.DeserializeObject<Partida>(apiResponse);
            }
        }
        return partida;
    }
    
    public async Task<Partida> AddPartida(Partida partida) {
        Partida partidaBerria = new Partida();
        using (var httpClient = new HttpClient()) {
            StringContent content = new StringContent(JsonConvert.SerializeObject(partida), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync(baseUri, content)) {
                string apiResponse = await response.Content.ReadAsStringAsync();
                partidaBerria = JsonConvert.DeserializeObject<Partida>(apiResponse);
            }
        }
        return partidaBerria;
    }
    
    public async Task<Partida> UpdatePartida(Partida partida) {
        Partida partidaBerria = new Partida();
        using (var httpClient = new HttpClient()) {
            StringContent content = new StringContent(JsonConvert.SerializeObject(partida), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PutAsync(baseUri + "/" + partida.id, content)) {
                string apiResponse = await response.Content.ReadAsStringAsync();
                partidaBerria = JsonConvert.DeserializeObject<Partida>(apiResponse);
            }
        }
        return partidaBerria;
    }
    
    public async Task<Partida> DeletePartida(int id) {
        Partida partidaBerria = new Partida();
        using (var httpClient = new HttpClient()) {
            using (var response = await httpClient.DeleteAsync(baseUri + "/" + id)) {
                string apiResponse = await response.Content.ReadAsStringAsync();
                partidaBerria = JsonConvert.DeserializeObject<Partida>(apiResponse);
            }
        }
        return partidaBerria;
    }
}