using System.Text.Json.Serialization;

namespace CarbonQuest.Main.Models
{
    public class Choice
    {
        [JsonPropertyName("Answer")]
        public string Answer { get; set; }

        [JsonPropertyName("Score")]
        public int Score { get; set; }
    }

    public class CarbonQuestion
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("Question")]
        public string Question { get; set; }

        [JsonPropertyName("Choices")]
        public List<Choice> Choices { get; set; }
    }
}