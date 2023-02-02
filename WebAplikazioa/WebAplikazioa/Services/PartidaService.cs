using Newtonsoft.Json;
using WebAplikazioa.Models;

namespace WebAplikazioa.Services {
    public class PartidaService : IPartidaService {
        /*sortuogun rest apiko helbidi berton ipini (odoo edo datu atzipeneku????)
        ariña ze datu dauezan gordeta jakin
        Mongoko datubasin gordeko di datu danak?(ikusi erronkako dokumentuko grafiku).
        */
        private Uri rutaTodos = new Uri("https://localhost:44367/api/Ardoa/");
        //igul beste ruta bat sortu 1.a jokalarientzat, 2.a partidentzat ???

        // (hurrengo datuk hasiera baten eztotaz biher, postgresegaz probak eitteko erabili ahaldi)
        // talde2: 6
        // talde4: 123

        /*public async Task<IList<ArdoaUpeltegi>> GetMota(int id)
        {
            List<ArdoaUpeltegi> ardoaUpeltegiList = new List<ArdoaUpeltegi>();
            Uri rutaUpeltegiak = new Uri(rutaTodos, "Mota/" + id.ToString());
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutaUpeltegiak))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ardoaUpeltegiList = JsonConvert.DeserializeObject<List<ArdoaUpeltegi>>(apiResponse);
                }
            }
            return ardoaUpeltegiList;
        }*/


        public async Task<List<PartidaModel>> GetPartidak() { //partida denak ikusteko
            List<PartidaModel> partidaList = new List<PartidaModel>();
            using (var httpClient = new HttpClient()) {
                using (var response = await httpClient.GetAsync(rutaTodos)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    partidaList = JsonConvert.DeserializeObject<List<PartidaModel>>(apiResponse);
                }
            }

            return partidaList;
        }

        public async Task<PartidaModel>
            GetPartida(int id) { //partida bat ikusteko
            PartidaModel partida = new PartidaModel();
            Uri rutaPartidaBat = new Uri(rutaTodos, id.ToString()); //rutaArdoBat
            using (var httpClient = new HttpClient()) {
                using (var response = await httpClient.GetAsync(rutaPartidaBat)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    partida = JsonConvert.DeserializeObject<PartidaModel>(apiResponse);
                }
            }
            return partida;
        }

        public async Task<List<PartidaModel>> GetPartidaOnenak(int zenbat) { //partida onenen ranking bat ikusteko
            List<PartidaModel> partidaOnenakList = new List<PartidaModel>();
            using (var httpClient = new HttpClient()) {
                using (var response = await httpClient.GetAsync(rutaTodos)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    partidaOnenakList = JsonConvert.DeserializeObject<List<PartidaModel>>(apiResponse);
                }
            }
            return partidaOnenakList;
        }
    }
}