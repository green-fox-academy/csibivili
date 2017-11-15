using Newtonsoft.Json;

namespace PandaScore.Models
{
    public class League
    {
        public int id { get; set; }
        [JsonIgnore]
        public object image_url { get; set; }
        [JsonIgnore]
        public object url { get; set; }
        public string name { get; set; }
        [JsonIgnore]
        public string slug { get; set; }
        public Videogame videogame { get; set; }
    }
}
