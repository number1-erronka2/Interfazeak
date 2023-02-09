namespace WebAplikazioa.ViewModels
{
    public class PartidaAleaViewModel
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
