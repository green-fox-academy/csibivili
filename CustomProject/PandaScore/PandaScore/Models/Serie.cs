using Newtonsoft.Json;

namespace PandaScore.Models
{
    public class Serie
    {
        public int id { get; set; }
        [JsonIgnore]
        public string slug { get; set; }
        public string name { get; set; }
        public string season { get; set; }
        public int year { get; set; }
    }
}
