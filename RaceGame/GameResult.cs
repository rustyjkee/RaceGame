using System.Text.Json.Serialization;

namespace Race
{
    public class GameResult
    {
        [JsonPropertyName("player_name")]
        public string Name { get; set; }

        [JsonPropertyName("player_score")] 
        public int Score { get; set; }

        [JsonPropertyName("player_coins")]
        public int CoinsCollected { get; set; }

        [JsonPropertyName("time_stamp")]
        public DateTime EntryTime { get; set; }

        public GameResult(string name, int score, int coinsCollected, DateTime entryTime)
        {
            Name = name;
            Score = score;
            CoinsCollected = coinsCollected;
            EntryTime = entryTime;
        }
    }
}
