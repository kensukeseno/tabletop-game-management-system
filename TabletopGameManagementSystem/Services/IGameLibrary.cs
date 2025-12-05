using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TabletopGameManagementSystem.Models;
using System.Text.Json;
using System.Diagnostics;

namespace TabletopGameManagementSystem.Services
{
    internal interface IGameLibrary
    {

        // Get all games data from the boardgames
        // Param: None
        // Return: List<Game>
        public List<Game> GetAllGames();

        // Get all categories from the categories
        // Param: None
        // Return: List<string>
        public List<string> GetAllCategories();

        // Get all collections data from the collections
        // Param: None
        // Return: List<Collection>
        public List<Collection> GetAllCollections();

        // Get all games in a given category
        // Param: category
        // Return: List<Game>
        public List<Game> GetAllGamesInCategory(string category);

        // Find all games data from the boardgames json file that match the given criteria
        // Param: name, minPlayers, maxPlayers, playingTime, ageSuitability, isWishlisted, isOwned, isFavorite
        // Return: List<Game>
        public List<Game> FindGames(string name = null, int minPlayers = 0, int maxPlayers = 0, int playingTime = 0, List<string> categories = null, int ageSuitability = 0, bool isWishlisted = false, bool isOwned = false, bool isFavorite = false);

        // AL - Taking advantage of overload so I don't rewrite the filtering logic above
        public List<Game> FindGames(FilterCriteria criteria);


        // Add a game to the boardgames json file
        // Param: game
        // Return: None
        public void AddGame(Game game);

        // Delete a game from the boardgames
        // Param: game id
        // Return: None
        public void DeleteGame(int id);

        // Add a collection to the collections
        // Param: collection
        // Return: None
        public void AddCollection(Collection collection);

        // Delete a collection from the collections
        // Param: collection id
        // Return: None
        public void DeleteCollection(int id);

        // Add a game to a collection
        // Param: game id, collection id
        // Return: None
        public void AddGameToCollection(int gameId, int collectionId);

        // Delete a game from a collection
        // Param: game id, collection id
        // Return: None
        public void DeleteGameFromCollection(int gameId, int collectionId);

        // Toggle isWished of a game
        // Param: game id
        // Return: None
        public void ToggleWishlisted(int id);

        // overload of ToggleWishlisted to set isWishlisted to a specific value
        public void ToggleWishlisted(int id, bool paramWishlist);

        // Toggle isFavorite of a game
        // Param: game id
        // Return: None
        public void ToggleFavorite(int id);

        // overload of ToggleFavorite to set isFavorite to a specific value
        public void ToggleFavorite(int id, bool paramFavorite);

        // Toggle isOwned of a game
        // Param: game id
        // Return: None
        public void ToggleOwned(int id);

        // overload of ToggleOwned to set isOwned to a specific value
        public void ToggleOwned(int id, bool paramOwned);
    }
}
