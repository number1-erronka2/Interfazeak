namespace WebAplikazioa.Models
{
    public class PartidaModel //HomeController.cs, Jokoak.cshtml eta Jokoa.cshtml fitxategietan erabiltzeko behar dena
    {
        public int Id { get; set; }
        public float Puntuazioa { get; set; }
        public DateOnly Data { get; set; }
        public string JokoIzena { get; set; }

        //honek bixek "langilea" barrun daz
        public int Taldea { get; set; }
        public string Erabiltzailea { get; set; }
        
    }
}