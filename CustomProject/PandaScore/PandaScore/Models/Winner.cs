using Newtonsoft.Json;

namespace PandaScore.Models
{
    public class Winner
    {
        public int? id { get; set; }
        public string name { get; set; }
        [JsonIgnore]
        public string acronym { get; set; }
        [JsonIgnore]
        public string image_url { get; set; }
    }
}
