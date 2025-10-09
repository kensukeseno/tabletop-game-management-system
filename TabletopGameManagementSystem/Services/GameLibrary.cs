using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TabletopGameManagementSystem.Models;
using TabletopGameManagementSystem.Data;

namespace TabletopGameManagementSystem.Services
{
    internal class GameLibrary
    {
        public List<Game> Games { get; set; }
        private static DateTime _defualtLastPlayed = new DateTime(1990, 1, 1);
        public List<Game> FindGames(string title = null, int rating = 0, int minPlayers = 0, int maxPlayers = 0, double playLength = 0, Genre genre = 0, Difficulty difficulty = 0, int ageSuitability = 0, DateTime lastPlayed = default, bool isOwned = false, bool isFavorite = false)
        {
            return new List<Game>();
        }
        public List<Game> SortGames(bool asc = true) 
        {
            return new List<Game>();
        }
    }
}
