namespace PandaScore.Models
{
    public class Player
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public object first_name { get; set; }
        public string last_name { get; set; }
        public object role { get; set; }
        public object bio { get; set; }
        public string hometown { get; set; }
        public object image_url { get; set; }
        public Team current_team { get; set; }
        public Videogame current_videogame { get; set; }
    }
}
