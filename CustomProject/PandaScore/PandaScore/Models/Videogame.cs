using Newtonsoft.Json;

namespace PandaScore.Models
{
    public class Videogame
    {
        public int id { get; set; }
        public string name { get; set; }
        [JsonIgnore]
        public string slug { get; set; }
    }
}
