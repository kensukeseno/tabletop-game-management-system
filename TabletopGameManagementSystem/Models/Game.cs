using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabletopGameManagementSystem.Models
{
    internal class Game
    {
        public string ID { get; }
        public string Title { get; }
        public string Desc { get; }
        public double Rating { get; }
        public int NumVoters { get; }
        public int MinPlayers { get; }
        public int MaxPlayers { get; }
        public int PlayLength { get; }
        public Genre Genre { get; }
        public Difficulty Difficulty { get; }
        public int AgeSuitability { get; }
        public DateTime? LastPlayed { get; set; }
        public bool isOwned { get; set; }
        public bool IsFavorite { get; set; }
        public Dictionary<string, string> CustomAttributes { get; set; }

        public Game(string id, string title, string desc, double rating, int numVoters, int minPlayer, int maxPlayers, int playLength, Genre genre, Difficulty difficulty, int ageSuitability, bool isOwned = false, bool IsFavorite = false)
        {
            ID = id;
            Title = title;
            Desc = desc;
            Rating = rating;
            NumVoters = numVoters;
            MinPlayers = minPlayer;
            MaxPlayers = maxPlayers;
            PlayLength = playLength;
            Genre = genre;
            Difficulty = difficulty;
            AgeSuitability = ageSuitability;
        }

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
