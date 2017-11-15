namespace PandaScore.Models
{
    public class Opponent
    {
        public int id { get; set; }
        public string type { get; set; }
        public Opponent2 opponent { get; set; }
    }
}
