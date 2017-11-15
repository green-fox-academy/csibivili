using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PandaScore.Models
{
    public class Tournament
    {
        public int id { get; set; }
        public string name { get; set; }
        [JsonIgnore]
        public string slug { get; set; }
        public int? winner_id { get; set; }
        public DateTime? begin_at { get; set; }
        public DateTime? end_at { get; set; }
        public int serie_id { get; set; }
        public int league_id { get; set; }
        public Serie serie { get; set; }
        public League league { get; set; }
        public Videogame videogame { get; set; }
        public List<Team> teams { get; set; }
        public List<Match> matches { get; set; }
    }
}
