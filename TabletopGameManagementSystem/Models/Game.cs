using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabletopGameManagementSystem.Models
{
    internal class Game(string id, string title, string desc, double rating, int numVoters, int minPlayer, int maxPlayers, int playLength, Genre genre, Difficulty difficulty, int ageSuitability, bool isOwned = false, bool IsFavorite = false)
    {
        public string ID { get; } = id;
        public string Title { get; } = title;
        public string Desc { get; } = desc;
        public double Rating { get; } = rating;
        public int NumVoters { get; } = numVoters;
        public int MinPlayers { get; } = minPlayer;
        public int MaxPlayers { get; } = maxPlayers;
        public int PlayLength { get; } = playLength;
        public Genre Genre { get; } = genre;
        public Difficulty Difficulty { get; } = difficulty;
        public int AgeSuitability { get; } = ageSuitability;
        public DateTime? LastPlayed { get; set; }
        public bool isOwned { get; set; }
        public bool IsFavorite { get; set; }
        public Dictionary<string, string>? CustomAttributes { get; set; }

        public void AddTag(string tag)
        {

        }

        public void RemoveTag(string tag)
        {

        }

        public void ToggleFavorite() 
        {
            IsFavorite = !IsFavorite;
        }

        public void UpdateAttribute(string key, string value)
        {

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
