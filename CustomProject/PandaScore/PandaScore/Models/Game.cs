using System;

namespace PandaScore.Models
{
    public class Game
    {
        public int id { get; set; }
        public int position { get; set; }
        public int? length { get; set; }
        public DateTime? begin_at { get; set; }
        public bool? finished { get; set; }
        public Winner winner { get; set; }
        public string winner_type { get; set; }
        public int match_id { get; set; }
    }
}
