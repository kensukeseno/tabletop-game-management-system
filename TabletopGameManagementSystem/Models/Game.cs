using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TabletopGameManagementSystem.Models
{
    internal class Game
    {
        // JSON-mapped properties
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

        public Dictionary<string, string>? CustomAttributes { get; set; }

        private bool userAdded;

        public bool GetUserAdded() => userAdded;

        public void SetUserAdded(bool value) => userAdded = value;

        // Default constructor needed for JSON and for : this()
        public Game()
        {
            Categories = new List<string>();
            CustomAttributes = new Dictionary<string, string>();
            userAdded = false;
        }

        // User-defined game constructor
        public Game(string name, string desc, int minPlayers, int maxPlayers,
                    int playingTime, List<string> categories, int ageSuitability)
            : this()
        {
            Name = name;
            Desc = desc;
            MinPlayers = minPlayers;
            MaxPlayers = maxPlayers;
            PlayingTime = playingTime;
            Categories = categories;
            AgeSuitability = ageSuitability;
            SetUserAdded(true);
        }

        public void AddTag(string tag)
        {
            // TODO: add custom tags
        }

        public void RemoveTag(string tag)
        {
            // TODO: remove custom tags
        }

        public void ToggleFavorite() =>
            IsFavorite = !IsFavorite;

        public void UpdateAttribute(string key, string value)
        {
            if (CustomAttributes == null)
                CustomAttributes = new Dictionary<string, string>();

            CustomAttributes[key] = value;
        }
    }

    public enum Difficulty
    {
        unknown,
        Easy,
        Medium,
        Hard
    }

    public enum Genre
    {
        unknown,
        Strategy,
        PartyGames,
        Cooperative,
        DeckBuilding,
        AbstractStrategy,
        WorkerPlacement,
        AreaControl_AreaInfluence,
        ResourceManagement,
        TileLaying,
        RolePlaying,
        Dexterity,
        Thematic,
        Deduction,
        Auction_Bidding,
        Trivia_QuizGames,
        LegacyGames
    }
}
