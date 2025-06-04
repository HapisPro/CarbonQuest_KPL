using System.Text.Json.Serialization;

namespace CarbonQuest.GUI.Models
{
    public class Article
    {
        [JsonPropertyName("id_article")]
        public string IdArticle { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
