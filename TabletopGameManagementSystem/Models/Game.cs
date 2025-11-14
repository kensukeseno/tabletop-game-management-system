using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace TabletopGameManagementSystem.Models
{
    internal class Game
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Desc { get; set; }
        [JsonPropertyName("rank")]
        public int Rank { get; set; }
        [JsonPropertyName("minplayers")]
        public int MinPlayers { get; set; }
        [JsonPropertyName("maxplayers")]
        public int MaxPlayers { get; set; }
        [JsonPropertyName("playingtime")]
        public int PlayingTime { get; set; }
        [JsonPropertyName("boardgamecategory")]
        public List<string> Categories { get; set; }
        [JsonPropertyName("age")]
        public int AgeSuitability { get; set; }
        [JsonPropertyName("lastplayed")]
        public DateTime? LastPlayed { get; set; }
        [JsonPropertyName("iswishlisted")]
        public bool IsWishlisted { get; set; }
        [JsonPropertyName("isowned")]
        public bool IsOwned { get; set; }
        [JsonPropertyName("isfavorite")]
        public bool IsFavorite { get; set; }
        [JsonPropertyName("useradded")]
        public bool UserAdded { get; set; }

        public Game(string name, string desc, int minPlayers, int maxPlayers, int playingTime, List<string> categories, int ageSuitability)
        {
            Name = name;
            Desc = desc;
            MinPlayers = minPlayers;
            MaxPlayers = maxPlayers;
            PlayingTime = playingTime;
            Categories = categories;
            AgeSuitability = ageSuitability;
            UserAdded = true;
        }
    }
}
