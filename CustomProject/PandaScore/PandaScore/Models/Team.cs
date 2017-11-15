using Newtonsoft.Json;
using System.Collections.Generic;

namespace PandaScore.Models
{
    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        [JsonIgnore]
        public string acronym { get; set; }
        [JsonIgnore]
        public object image_url { get; set; }
        public List<Player> players { get; set; }
        public Videogame current_videogame { get; set; }
    }
}
