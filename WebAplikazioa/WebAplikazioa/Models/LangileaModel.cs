namespace WebAplikazioa.Models
{
    public class LangileaModel //HomeController.cs, Jokoak.cshtml eta Jokoa.cshtml fitxategietan erabiltzeko behar dena
    {
        public string E_mail { get; set; }
        public string Izena { get; set; }
        public string User { get; set; }
        public DateOnly Jaiotza_data { get; set; }
        public int Taldea { get; set; }
        //
    }
}