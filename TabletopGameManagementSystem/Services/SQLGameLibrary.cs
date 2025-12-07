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
using Microsoft.Data.SqlClient;

namespace TabletopGameManagementSystem.Services
{
    internal class SQLGameLibrary : IGameLibrary
    {
        private string _connectionString = "Data Source=ANDREILAQUI\\SQLEXPRESS;Initial Catalog=TurnTable;"
                + "Integrated Security=true;TrustServerCertificate=True";

        // Get all games data from the boardgames json file
        // Param: None
        // Return: List<Game>
        public List<Game> GetAllGames() 
        {
            string queryString =
                "SELECT * FROM BoardGames;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    return DataReaderMapper.DataReaderToList<Game, string>(reader, "boardgamecategory");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        // Get all categories from the categories
        // Param: None
        // Return: List<string>
        public List<string> GetAllCategories()
        {
            string queryString =
                "SELECT Name FROM Categories;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    List<string> categories = new List<string>();
                    while (reader.Read())
                    {
                        categories.Add((string)reader[0]);
                    }
                    return categories;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        // Get all collections data from the collections
        // Param: None
        // Return: List<Collection>
        public List<Collection> GetAllCollections()
        {
            string queryString =
                "SELECT * FROM Collections;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    return DataReaderMapper.DataReaderToList<Collection, int>(reader, "boardgameid");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        // Get all games in a given category
        // Param: category
        // Return: List<Game>
        public List<Game> GetAllGamesInCategory(string category)
        {
            List<Game> games = GetAllGames();
            List<Game> gamesInCategory = games.Where(game => game.Categories.Contains(category)).ToList();
            return gamesInCategory;
        }

        // Find all games data from the boardgames json file that match the given criteria
        // Param: name, minPlayers, maxPlayers, playingTime, ageSuitability, isWishlisted, isOwned, isFavorite
        // Return: List<Game>
        public List<Game> FindGames(string name = null, int minPlayers = 0, int maxPlayers = 0, int playingTime = 0, List<string> categories = null, int ageSuitability = 0, bool isWishlisted = false, bool isOwned = false, bool isFavorite = false)
        {
            List<Game> games = GetAllGames();

            if (name != null)
            {
                games = games.Where(game => game.Name.ToLower().Contains(name.Trim().ToLower())).ToList();
            }
            if (minPlayers != 0)
            {
                games = games.Where(game => game.MinPlayers == minPlayers).ToList();
            }
            if (maxPlayers != 0)
            {
                games = games.Where(game => game.MaxPlayers == maxPlayers).ToList();
            }
            if (playingTime != 0)
            {
                games = games.Where(game => game.PlayingTime <= playingTime).ToList();
            }
            if (categories?.Any() == true)
            {
                games = games.Where(game => categories.Any(category => game.Categories.Contains(category))).ToList();
            }
            if (ageSuitability != 0)
            {
                games = games.Where(game => game.AgeSuitability <= ageSuitability).ToList();
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

        public List<Game> FindGames(FilterCriteria criteria)
        {
            return FindGames(
                name: criteria.NameContains,
                minPlayers: criteria.MinPlayers,
                maxPlayers: criteria.MaxPlayers,
                playingTime: criteria.PlayingTime,
                categories: criteria.Categories,
                ageSuitability: criteria.AgeSuitability,
                isWishlisted: criteria.IsWishlisted,
                isOwned: criteria.IsOwned,
                isFavorite: criteria.IsFavorite
            );
        }

        // Add a game to the boardgames
        // Param: game
        // Return: None
        public void AddGame(Game game)
        {
            var categoriesJson = JsonSerializer.Serialize(new
            {
                boardgamecategory = game.Categories
            });

            string queryString =
                $"INSERT INTO BoardGames VALUES('{game.Name}', '{game.Desc}',{game.Rank}, {game.MinPlayers}, {game.MaxPlayers}, {game.PlayingTime}, {game.AgeSuitability}, null, 0, 0, 0, '{categoriesJson}');";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    int rowAffected = command.ExecuteNonQuery();
                    if (rowAffected == 0)
                    {
                        throw new Exception("The game data was not saved.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        // Delete a game from the boardgames json file
        // Param: game id
        // Return: None
        public void DeleteGame(int id)
        {
            // Delete a game from BordGame table
            string queryString =
                $"DELETE FROM BoardGames WHERE ID = {id};";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    int rowAffected = command.ExecuteNonQuery();
                    if (rowAffected == 0)
                    {
                        throw new Exception("The game data was not saved.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Delete a game id from collections
            // Step 1. Get all collection ids
            string selectQueryString =
                $"SELECT ID FROM Collections;";
            List<int> collectionIds = new List<int>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(selectQueryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        collectionIds.Add((int)reader[0]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            // Step 2. Delete the game id from all collections
            foreach (var collectionId in collectionIds) {
                DeleteGameFromCollection(id, collectionId);
            }
        }
        // Add a collection to the collections json file
        // Param: collection
        // Return: None
        public void AddCollection(Collection collection)
        {
            string queryString =
                $"INSERT INTO Collections (Name, GameIds) VALUES('{collection.Name}', '{{\"boardgameid\": []}}');";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    int rowAffected = command.ExecuteNonQuery();
                    if (rowAffected == 0)
                    {
                        throw new Exception("The collection data was not saved.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        // Delete a collection from the collections json file
        // Param: collection id
        // Return: None
        public void DeleteCollection(int id)
        {
            string queryString =
                $"DELETE FROM Collections WHERE ID = {id};";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    int rowAffected = command.ExecuteNonQuery();
                    if (rowAffected == 0)
                    {
                        throw new Exception("The collection data was not saved.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        // Add a game to a collection
        // Param: game id, collection id
        // Return: None
        public void AddGameToCollection(int gameId, int collectionId)
        {
            // Step 1. Get the current game ids in the collection
            string selectQueryString =
                $"SELECT GameIds FROM Collections WHERE ID = {collectionId};";
            List<int> gameIds = new List<int>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(selectQueryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    // Access the target array
                    var resultArray = JsonDocument.Parse((string)reader[0]).RootElement.GetProperty("boardgameid").EnumerateArray();
                    foreach (JsonElement element in resultArray)
                    {
                        // Get the string value from each element
                        gameIds.Add(JsonSerializer.Deserialize<int>(element.GetRawText()));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Step 2. Add a game id to the collection
            gameIds.Add(gameId);
            string jsonObject = "{\"boardgameid\": " + JsonSerializer.Serialize(gameIds) + "}";
            string updateQueryString =
                $"UPDATE Collections SET GameIds = '{jsonObject}' WHERE ID = {collectionId};";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(updateQueryString, connection);

                try
                {
                    connection.Open();
                    int rowAffected = command.ExecuteNonQuery();
                    if (rowAffected == 0)
                    {
                        throw new Exception("The collection data was not saved.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        // Delete a game from a collection
        // Param: game id, collection id
        // Return: None
        public void DeleteGameFromCollection(int gameId, int collectionId)
        {
            // Step 1. Get the current game ids in the collection
            string selectQueryString =
                $"SELECT GameIds FROM Collections WHERE ID = {collectionId};";
            List<int> currentGameIds = new List<int>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(selectQueryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    // Access the target array
                    var resultArray = JsonDocument.Parse((string)reader[0]).RootElement.GetProperty("boardgameid").EnumerateArray();
                    foreach (JsonElement element in resultArray)
                    {
                        // Get the string value from each element
                        currentGameIds.Add(JsonSerializer.Deserialize<int>(element.GetRawText()));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Step 2. Delete the game id from the collection
            List<int> updatedGameIds = currentGameIds.Where(id => id != gameId).ToList<int>();
            string jsonObject = "{\"boardgameid\": " + JsonSerializer.Serialize(updatedGameIds) + "}";
            string updateQueryString =
                $"UPDATE Collections SET GameIds = '{jsonObject}' WHERE ID = {collectionId};";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(updateQueryString, connection);

                try
                {
                    connection.Open();
                    int rowAffected = command.ExecuteNonQuery();
                    if (rowAffected == 0)
                    {
                        throw new Exception("The collection data was not saved.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        // Toggle isWished of a game
        // Param: game id
        // Return: None
        public void ToggleWishlisted(int id)
        {
            // Step 1: Get the current value of wishlisted
            string selectQueryString =
                $"SELECT IsWishlisted FROM Boardgames Where id = {id};";

            bool wishListed = false;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(selectQueryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();
                    wishListed = (bool)reader[0];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Step 2: Toggle the value
            string updateQueryString;
            if (wishListed == false) updateQueryString = $"UPDATE Boardgames SET IsWishlisted = 1 Where id = {id};";
            else updateQueryString = $"UPDATE Boardgames SET IsWishlisted = 0 Where id = {id};";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(updateQueryString, connection);

                try
                {
                    connection.Open();
                    int rowAffected = command.ExecuteNonQuery();

                    if (rowAffected == 0)
                    {
                        throw new Exception("The Wishlisted data was not toggled.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void ToggleWishlisted(int id, bool paramWishlist)
        {
            // Step 1: Get the current value of wishlisted
            string selectQueryString =
                $"SELECT IsWishlisted FROM Boardgames Where id = {id};";

            bool wishListed = false;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(selectQueryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();
                    wishListed = (bool)reader[0];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            // Toggle if neccesary
            if (wishListed != paramWishlist)
            {
                ToggleWishlisted(id);
            }
        }

        // Toggle isFavorite of a game
        // Param: game id
        // Return: None
        public void ToggleFavorite(int id)
        {
            // Step 1: Get the current value of wishlisted
            string selectQueryString =
                $"SELECT IsFavorite FROM Boardgames Where id = {id};";

            bool isFavorite = false;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(selectQueryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();
                    isFavorite = (bool)reader[0];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Step 2: Toggle the value
            string updateQueryString;
            if (isFavorite == false) updateQueryString = $"UPDATE Boardgames SET IsFavorite = 1 Where id = {id};";
            else updateQueryString = $"UPDATE Boardgames SET IsFavorite = 0 Where id = {id};";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(updateQueryString, connection);

                try
                {
                    connection.Open();
                    int rowAffected = command.ExecuteNonQuery();

                    if (rowAffected == 0)
                    {
                        throw new Exception("The IsFavorite data was not toggled.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void ToggleFavorite(int id, bool paramFavorite)
        {
            // Step 1: Get the current value of wishlisted
            string selectQueryString =
                $"SELECT IsFavorite FROM Boardgames Where id = {id};";

            bool isFavorite = false;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(selectQueryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();
                    isFavorite = (bool)reader[0];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Toggle if neccesary
            if (isFavorite != paramFavorite)
            {
                ToggleFavorite(id);
            }
        }

        // Toggle isOwned of a game
        // Param: game id
        // Return: None
        public void ToggleOwned(int id)
        {
            // Step 1: Get the current value of wishlisted
            string selectQueryString =
                $"SELECT IsOwned FROM Boardgames Where id = {id};";

            bool isOwned = false;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(selectQueryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();
                    isOwned = (bool)reader[0];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Step 2: Toggle the value
            string updateQueryString;
            if (isOwned == false) updateQueryString = $"UPDATE Boardgames SET IsOwned = 1 Where id = {id};";
            else updateQueryString = $"UPDATE Boardgames SET IsOwned = 0 Where id = {id};";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(updateQueryString, connection);

                try
                {
                    connection.Open();
                    int rowAffected = command.ExecuteNonQuery();

                    if (rowAffected == 0)
                    {
                        throw new Exception("The IsOwned data was not toggled.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void ToggleOwned(int id, bool paramOwned)
        {
            // Step 1: Get the current value of wishlisted
            string selectQueryString =
                $"SELECT IsOwned FROM Boardgames Where id = {id};";

            bool isOwned = false;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(selectQueryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();
                    isOwned = (bool)reader[0];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Toggle if neccesary
            if (isOwned != paramOwned)
            {
                ToggleOwned(id);
            }
        }
    }
}
