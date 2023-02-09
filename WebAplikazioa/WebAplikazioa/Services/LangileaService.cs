using Newtonsoft.Json;
using WebAplikazioa.Models;

namespace WebAplikazioa.Services
{
    public class LangileaService : ILangileaService
    {



        /*sortuogun rest apiko helbidi berton ipini (odoo edo datu atzipeneku????)
        ariña ze datu dauezan gordeta jakin
        Mongoko datubasin gordeko di datu danak?(ikusi erronkako dokumentuko grafiku).
        */





        //private Uri rutaDenak = new Uri("https://localhost:44367/api/Langilea/");

        //http://192.168.65.123:8989/swagger-ui/index.html#/
        private Uri rutaDenak = new Uri("http://192.168.65.123:8989/");




        //igul beste ruta bat sortu 1.a jokalarientzat, 2.a partidentzat ???

        // (hurrengo datuk hasiera baten eztotaz biher, postgresegaz probak eitteko erabili ahaldi)
        // talde2: 6
        // talde4: 123


        /*public async Task<IList<ArdoaUpeltegi>> GetMota(int id)
        {
            List<ArdoaUpeltegi> ardoaUpeltegiList = new List<ArdoaUpeltegi>();
            Uri rutaPartidak = new Uri(rutaDenak, "Mota/" + id.ToString());
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutaPartidak))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ardoaUpeltegiList = JsonConvert.DeserializeObject<List<ArdoaUpeltegi>>(apiResponse);
                }
            }//
            return ardoaUpeltegiList;
        }*/







        public async Task<List<LangileaModel>> GetLangileak()
        {
            List<LangileaModel> langileaList = new List<LangileaModel>();


            Uri rutaPartidak = new Uri(rutaDenak, "partidak/allPartida");


            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutaPartidak))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    langileaList = JsonConvert.DeserializeObject<List<LangileaModel>>(apiResponse);
                }
            }
            return langileaList;
        }
        public async Task<LangileaModel> GetLangilea(int id)
        {
            LangileaModel langileaList = new LangileaModel();
            Uri rutaLangileBat = new Uri(rutaDenak, id.ToString());
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutaLangileBat))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    langileaList = JsonConvert.DeserializeObject<LangileaModel>(apiResponse);
                }
            }
            return langileaList;
        }
    }
}