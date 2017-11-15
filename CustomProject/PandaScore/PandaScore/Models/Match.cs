using System;
using System.Collections.Generic;

namespace PandaScore.Models
{
    public class Match
    {
        public int id { get; set; }
        public int tournament_id { get; set; }
        public string name { get; set; }
        public DateTime? begin_at { get; set; }
        public List<Result> results { get; set; }
        public int serie_id { get; set; }
        public int league_id { get; set; }
        public Serie serie { get; set; }
        public League league { get; set; }
        public DateTime updated_at { get; set; }
        public int number_of_games { get; set; }
        public Videogame videogame { get; set; }
        public Tournament tournament { get; set; }
        public Winner winner { get; set; }
        public List<Game> games { get; set; }
        public List<Opponent> opponents { get; set; }
    }
}
