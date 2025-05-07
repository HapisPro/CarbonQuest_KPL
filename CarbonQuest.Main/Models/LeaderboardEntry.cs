using System.Text.Json.Serialization;

namespace CarbonQuest.Main.Models
{
    public class LeaderboardEntry
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("score")]
        public int Score { get; set; }
    }
}
