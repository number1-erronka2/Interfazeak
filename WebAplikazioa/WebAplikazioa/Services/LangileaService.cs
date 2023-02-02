using Newtonsoft.Json;
using WebAplikazioa.Models;

namespace WebAplikazioa.Services {
    public class LangileaService : ILangileaService {
        /*sortuogun rest apiko helbidi berton ipini (odoo edo datu atzipeneku????)
        ariña ze datu dauezan gordeta jakin
        Mongoko datubasin gordeko di datu danak?(ikusi erronkako dokumentuko grafiku).
        */
        private Uri rutaTodos = new Uri("https://localhost:44367/api/Langilea/");
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
            }//
            return ardoaUpeltegiList;
        }*/


        //datubaseak:
        //partida(id,user,puntuazioa,data) PK=id FK=user
        //langilea(e-mail,izena,user,jaiotza-data,taldea) PK=user


        public async Task<List<LangileaModel>> GetLangileak() {
            List<LangileaModel> langileaList = new List<LangileaModel>();
            using (var httpClient = new HttpClient()) {
                using (var response = await httpClient.GetAsync(rutaTodos)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    langileaList = JsonConvert.DeserializeObject<List<LangileaModel>>(apiResponse);
                }
            }

            return langileaList;
        }

        public async Task<LangileaModel> GetLangilea(string user) {
            LangileaModel langileaList = new LangileaModel();
            Uri rutaLangileBat = new Uri(rutaTodos, user);
            using (var httpClient = new HttpClient()) {
                using (var response = await httpClient.GetAsync(rutaLangileBat)) {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    langileaList = JsonConvert.DeserializeObject<LangileaModel>(apiResponse);
                }
            }
            return langileaList;
        }
    }
}