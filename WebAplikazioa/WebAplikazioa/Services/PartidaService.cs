using Newtonsoft.Json;
using WebAplikazioa.Models;
using WebAplikazioa.ViewModels;

namespace WebAplikazioa.Services
{
    public class PartidaService : IPartidaService
    {



        /*sortuogun rest apiko helbidi berton ipini (odoo edo datu atzipeneku????)
        ariña ze datu dauezan gordeta jakin
        Mongoko datubasin gordeko di datu danak?(ikusi erronkako dokumentuko grafiku).
        */





        //private Uri rutaDenak = new Uri("https://localhost:44367/api/Ardoa/");

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
            }
            return ardoaUpeltegiList;
        }*/












        public async Task<List<PartidaModel>> GetPartidak() //partida denak ikusteko
        {// 
            List<PartidaModel> partidaList = new List<PartidaModel>();

            Uri rutaPartidak = new Uri(rutaDenak, "partidak/allPartida");


            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutaPartidak))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    partidaList = JsonConvert.DeserializeObject<List<PartidaModel>>(apiResponse);
                }
            }
            return partidaList;
        }









        public async Task<List<PartidaAleaViewModel>> GetPartidak2() //partida denak ikusteko
        {// 
            List<PartidaAleaViewModel> partidaList = new List<PartidaAleaViewModel>();

            Uri rutaPartidak = new Uri(rutaDenak, "/partidak/allPartida");


            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutaPartidak))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    partidaList = JsonConvert.DeserializeObject<List<PartidaAleaViewModel>>(apiResponse);
                }
            }
            return partidaList;
        }












        public async Task<PartidaModel> GetPartida(int id) //partida 1 ikusteko (edo beztelan hau erabiltzaile 1en partidak ikusteko???)
        {
            PartidaModel partida = new PartidaModel();
            Uri rutaPartidaBat = new Uri(rutaDenak, "partidak/partida/{id}" + id.ToString()); //rutaArdoBat
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutaPartidaBat))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    partida = JsonConvert.DeserializeObject<PartidaModel>(apiResponse);
                }
            }
            return partida;
        }
        public async Task<List<PartidaModel>> GetPartidaOnenak() //rankingean sartzeko
        {
            List<PartidaModel> partidaOnenakList = new List<PartidaModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutaDenak))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    partidaOnenakList = JsonConvert.DeserializeObject<List<PartidaModel>>(apiResponse);
                }
            }
            return partidaOnenakList;
        }
    }
}