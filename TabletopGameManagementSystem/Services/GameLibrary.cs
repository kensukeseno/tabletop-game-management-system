//handles JSON load, save, filtering, and basic operations on games & collections

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
    internal class GameLibrary
    {
        private static string _binDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private static string _boardgamefilePath = Path.Combine(_binDirectory, "Data/boardgames.json");
        private static string _collectionfilePath = Path.Combine(_binDirectory, "Data/collections.json");
        private static string _categoryfilePath = Path.Combine(_binDirectory, "Data/categories.json");

        private static int _maxIdInTop100 = 421006;

        // Get all games data from the boardgames json file
        // Param: None
        // Return: List<Game>
        public List<Game> GetAllGames() 
        {
            try
            {
                string jsonString = File.ReadAllText(_boardgamefilePath);
                List<Game> games = JsonSerializer.Deserialize<List<Game>>(jsonString);

                return games;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        // Get all categories from the categories json file
        // Param: None
        // Return: List<string>
        public List<string> GetAllCategories()
        {
            try
            {
                string jsonString = File.ReadAllText(_categoryfilePath);
                List<string> categories = JsonSerializer.Deserialize<List<string>>(jsonString);

                return categories;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        // Get all collections data from the collections json file
        // Param: None
        // Return: List<Collection>
        public List<Collection> GetAllCollections()
        {
            try
            {
                string jsonString = File.ReadAllText(_collectionfilePath);
                List<Collection> collections = JsonSerializer.Deserialize<List<Collection>>(jsonString);
                return collections;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        // Get all games in a given category
        // Param: category
        // Return: List<Game>
        public List<Game> GetAllGamesInCategory(string category)
        {
            try
            {
                string jsonString = File.ReadAllText(_boardgamefilePath);
                List<Game> games = JsonSerializer.Deserialize<List<Game>>(jsonString);

                List<Game> gamesInCategory = games.Where(game => game.Categories.Contains(category)).ToList();

                return gamesInCategory;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        // Find all games data from the boardgames json file that match the given criteria
        // Param: name, minPlayers, maxPlayers, playingTime, ageSuitability, isWishlisted, isOwned, isFavorite
        // Return: List<Game>
        public List<Game> FindGames(string name = null, int minPlayers = 0, int maxPlayers = 0, int playingTime = 0, List<string> categories = null, int ageSuitability = 0, bool isWishlisted = false, bool isOwned = false, bool isFavorite = false)
        {
            try
            {
                string jsonString = File.ReadAllText(_boardgamefilePath);
                List<Game> games = JsonSerializer.Deserialize<List<Game>>(jsonString);

                if (name != null)
                {
                    games = games.Where(game => game.Name.ToLower().Contains(name.Trim().ToLower())).ToList();
                }
                if(minPlayers != 0)
                {
                    games = games.Where(game => game.MinPlayers >= minPlayers).ToList();
                }
                if (maxPlayers != 0)
                {
                    games = games.Where(game => game.MaxPlayers <= maxPlayers).ToList();
                }
                if (playingTime != 0)
                {
                    games = games.Where(game => game.PlayingTime <= playingTime).ToList();
                }
                if (categories != null)
                {
                    games = games.Where(game => 
                        {
                            foreach (var category in categories) {
                                if(game.Categories.Contains(category)) return true;
                            }
                            return false;
                        }).ToList();
                }
                if (ageSuitability != 0)
                {
                    games = games.Where(game => game.AgeSuitability >= ageSuitability).ToList();
                }
                if (isWishlisted) 
                {
                    games = games.Where(game => game.IsWishlisted).ToList();
                }
                if (isOwned)
                {
                    games = games.Where(game => game.IsOwned).ToList();
                }
                if (isFavorite)
                {
                    games = games.Where(game => game.IsFavorite).ToList();
                }

                return games;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        // AL - Taking advantage of overload so I don't rewrite the filtering logic above
        public List<Game> FindGames(FilterCriteria criteria)
        {
            return FindGames(
                name: criteria.NameContains,
                minPlayers: criteria.MinPlayers,
                maxPlayers: criteria.MaxPlayers,
                playingTime: criteria.PlayingTime,
                categories: null,
                ageSuitability: criteria.AgeSuitability,
                isWishlisted: criteria.IsWishlisted,
                isOwned: criteria.IsOwned,
                isFavorite: criteria.IsFavorite
            );
        }



        // Add a game to the boardgames json file
        // Param: game
        // Return: None
        public void AddGame(Game game)
        {
            try
            {
                string jsonString = File.ReadAllText(_boardgamefilePath);
                List<Game> games = JsonSerializer.Deserialize<List<Game>>(jsonString);

                // Set id
                // The id of the first added game is an increment from the max id of top 100 games
                // From the second game, the id is simply an increment from the last added game's id
                if (games.Last().ID > _maxIdInTop100)
                {
                    game.ID = games.Last().ID + 1;
                }
                else
                {
                    game.ID = _maxIdInTop100 + 1;
                }
                games.Add(game);
                string newJsonString = JsonSerializer.Serialize(games);
                File.WriteAllText(_boardgamefilePath, newJsonString);
                Debug.WriteLine($"Writing to {_boardgamefilePath} from {nameof(ToggleOwned)}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        // Delete a game from the boardgames json file
        // Param: game id
        // Return: None
        public void DeleteGame(int id)
        {
            try
            {
                string jsonString = File.ReadAllText(_boardgamefilePath);
                List<Game> games = JsonSerializer.Deserialize<List<Game>>(jsonString);

                List<Game> deletedGames = games.Where(game => game.ID != id).ToList();

                string newJsonString = JsonSerializer.Serialize(deletedGames);
                File.WriteAllText(_boardgamefilePath, newJsonString);
                Debug.WriteLine($"Writing to {_boardgamefilePath} from {nameof(ToggleOwned)}");

                // Delete this game from all the collections
                string collectionJsonString = File.ReadAllText(_collectionfilePath);
                List<Collection> collections = JsonSerializer.Deserialize<List<Collection>>(collectionJsonString);
                foreach (var collection in collections)
                {
                    DeleteGameFromCollection(id, collection.ID);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        // Add a collection to the collections json file
        // Param: collection
        // Return: None
        public void AddCollection(Collection collection)
        {
            try
            {
                string jsonString = File.ReadAllText(_collectionfilePath);
                List<Collection> collections = JsonSerializer.Deserialize<List<Collection>>(jsonString);

                // Prevent duplicate
                if (collections.Find(c => c.Name == collection.Name) == null)
                {
                    // Set id
                    if (collections.Count == 0)
                    {
                        collection.ID = 1;
                    }
                    else
                    {
                        collection.ID = collections.Last().ID + 1;
                    }

                    collections.Add(collection);
                    jsonString = JsonSerializer.Serialize(collections);
                    File.WriteAllText(_collectionfilePath, jsonString);
                    Debug.WriteLine($"Writing to {_collectionfilePath} from {nameof(ToggleOwned)}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        // Delete a collection from the collections json file
        // Param: collection id
        // Return: None
        public void DeleteCollection(int id)
        {
            try
            {
                string jsonString = File.ReadAllText(_collectionfilePath);
                List<Collection> collections = JsonSerializer.Deserialize<List<Collection>>(jsonString);
                
                List<Collection> deletedCollections = collections.Where(collection => collection.ID != id).ToList();

                jsonString = JsonSerializer.Serialize(deletedCollections);
                File.WriteAllText(_collectionfilePath, jsonString);
                Debug.WriteLine($"Writing to {_collectionfilePath} from {nameof(ToggleOwned)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        // Add a game to a collection
        // Param: game id, collection id
        // Return: None
        public void AddGameToCollection(int gameId, int collectionId)
        {
            try
            {
                string jsonString = File.ReadAllText(_collectionfilePath);
                List<Collection> collections = JsonSerializer.Deserialize<List<Collection>>(jsonString);

                int index = collections.FindIndex(collection => collection.ID == collectionId);

                if (!collections[index].GameIds.Contains(gameId))
                {
                    collections[index].GameIds.Add(gameId);
                }

                jsonString = JsonSerializer.Serialize(collections);
                File.WriteAllText(_collectionfilePath, jsonString);
                Debug.WriteLine($"Writing to {_collectionfilePath} from {nameof(ToggleOwned)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        // Delete a game from a collection
        // Param: game id, collection id
        // Return: None
        public void DeleteGameFromCollection(int gameId, int collectionId)
        {
            try
            {
                string jsonString = File.ReadAllText(_collectionfilePath);
                List<Collection> collections = JsonSerializer.Deserialize<List<Collection>>(jsonString);

                int index = collections.FindIndex(collection => collection.ID == collectionId);

                collections[index].GameIds = collections[index].GameIds.Where(id => id != gameId).ToList();

                jsonString = JsonSerializer.Serialize(collections);
                File.WriteAllText(_collectionfilePath, jsonString);
                Debug.WriteLine($"Writing to {_collectionfilePath} from {nameof(ToggleOwned)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        // Toggle isWished of a game
        // Param: game id
        // Return: None
        public void ToggleWishlisted(int id)
        {
            try
            {
                string jsonString = File.ReadAllText(_boardgamefilePath);
                List<Game> games = JsonSerializer.Deserialize<List<Game>>(jsonString);

                int index = games.FindIndex(game => game.ID == id);
                games[index].IsWishlisted = !games[index].IsWishlisted;

                string newJsonString = JsonSerializer.Serialize(games);
                File.WriteAllText(_boardgamefilePath, newJsonString);
                Debug.WriteLine($"Writing to {_boardgamefilePath} from {nameof(ToggleOwned)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // overload of ToggleWishlisted to set isWishlisted to a specific value
        public void ToggleWishlisted(int id, bool paramWishlist)
        {
            try
            {
                string jsonString = File.ReadAllText(_boardgamefilePath);
                List<Game> games = JsonSerializer.Deserialize<List<Game>>(jsonString);

                int index = games.FindIndex(game => game.ID == id);
                games[index].IsWishlisted = paramWishlist;

                string newJsonString = JsonSerializer.Serialize(games);
                File.WriteAllText(_boardgamefilePath, newJsonString);
                Debug.WriteLine($"Writing to {_boardgamefilePath} from {nameof(ToggleOwned)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Toggle isFavorite of a game
        // Param: game id
        // Return: None
        public void ToggleFavorite(int id)
        {
            try
            {
                string jsonString = File.ReadAllText(_boardgamefilePath);
                List<Game> games = JsonSerializer.Deserialize<List<Game>>(jsonString);

                int index = games.FindIndex(game => game.ID == id);
                games[index].IsFavorite = !games[index].IsFavorite;

                string newJsonString = JsonSerializer.Serialize(games);
                File.WriteAllText(_boardgamefilePath, newJsonString);
                Debug.WriteLine($"Writing to {_boardgamefilePath} from {nameof(ToggleOwned)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // overload of ToggleFavorite to set isFavorite to a specific value
        public void ToggleFavorite(int id, bool paramFavorite)
        {
            try
            {
                string jsonString = File.ReadAllText(_boardgamefilePath);
                List<Game> games = JsonSerializer.Deserialize<List<Game>>(jsonString);

                int index = games.FindIndex(game => game.ID == id);
                games[index].IsFavorite = paramFavorite;

                string newJsonString = JsonSerializer.Serialize(games);
                File.WriteAllText(_boardgamefilePath, newJsonString);
                Debug.WriteLine($"Writing to {_boardgamefilePath} from {nameof(ToggleOwned)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        // Toggle isOwned of a game
        // Param: game id
        // Return: None
        public void ToggleOwned(int id)
        {
            try
            {
                string jsonString = File.ReadAllText(_boardgamefilePath);
                List<Game> games = JsonSerializer.Deserialize<List<Game>>(jsonString);

                int index = games.FindIndex(game => game.ID == id);
                games[index].IsOwned = !games[index].IsOwned;

                Debug.WriteLine($"Writing IsOwned={games[index].IsOwned} for game {games[index].Name} (ID {id})");

                string newJsonString = JsonSerializer.Serialize(games);
                File.WriteAllText(_boardgamefilePath, newJsonString);
                Debug.WriteLine($"Writing to {_boardgamefilePath} from {nameof(ToggleOwned)}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // overload of ToggleOwned to set isOwned to a specific value
        public void ToggleOwned(int id, bool paramOwned)
        {
            try
            {
                string jsonString = File.ReadAllText(_boardgamefilePath);
                List<Game> games = JsonSerializer.Deserialize<List<Game>>(jsonString);

                int index = games.FindIndex(game => game.ID == id);
                games[index].IsOwned = paramOwned;

                Debug.WriteLine($"Writing IsOwned={games[index].IsOwned} for game {games[index].Name} (ID {id})");

                string newJsonString = JsonSerializer.Serialize(games);
                File.WriteAllText(_boardgamefilePath, newJsonString);
                Debug.WriteLine($"Writing to {_boardgamefilePath} from {nameof(ToggleOwned)}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

    }
}
