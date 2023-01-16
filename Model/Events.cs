using System.Text.Json;
using System.Text.Json.Serialization;

namespace Tech_Mela_Final.Model
{
    public class Events
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("image")]
        public string image { get; set; }

        [JsonPropertyName("category")]
        public string category { get; set; }

        [JsonPropertyName("speaker_name")]
        public string spkear_name { get; set; }

        [JsonPropertyName("heading")]
        public string heading { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        /* here we have have json file we need to store the data in a specfic formate so here we need to
    override the function that will convert our string into the specific json formate */
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}

