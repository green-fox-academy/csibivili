using Newtonsoft.Json;

namespace PandaScore.Models
{
    public class Player
    {
        public int id { get; set; }
        [JsonIgnore]
        public string slug { get; set; }
        public string name { get; set; }
        [JsonIgnore]
        public object first_name { get; set; }
        [JsonIgnore]
        public string last_name { get; set; }
        [JsonIgnore]
        public object role { get; set; }
        [JsonIgnore]
        public object bio { get; set; }
        [JsonIgnore]
        public string hometown { get; set; }
        [JsonIgnore]
        public object image_url { get; set; }
        public Team current_team { get; set; }
        public Videogame current_videogame { get; set; }
    }
}
