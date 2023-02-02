namespace WebAplikazioa.Models
{
    public class PartidaModel //HomeController.cs, Jokoak.cshtml eta Jokoa.cshtml fitxategietan erabiltzeko behar dena
    {
        public int Id { get; set; }
        public string User { get; set; }
        public float Puntuazioa { get; set; }
        public DateOnly Data { get; set; }
        //
    }
}