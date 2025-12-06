using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using TabletopGameManagementSystem.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TabletopGameManagementSystem.Services
{
    internal static class DataReaderMapper
    {
        public static List<T1> DataReaderToList<T1, T2>(SqlDataReader reader, string propName) where T1 : new()
        {
            var list = new List<T1>();
            var props = typeof(T1).GetProperties();

            while (reader.Read())
            {
                T1 obj = new T1();

                foreach (var prop in props)
                {
                    if (!reader.HasColumn(prop.Name) || reader[prop.Name] is DBNull)
                        continue;

                    var value = reader[prop.Name];

                    // Check if the property is of type string (potential JSON string)
                    if (value is string jsonString)
                    {
                        // Check if the column contains valid JSON (or could be a JSON object)
                        if (IsValidJson(jsonString))
                        {
                            // Modify the JSON data before setting it (if needed)
                            value = ModifyJsonData<T2>(jsonString, propName);
                        }
                    }
                    prop.SetValue(obj, value);
                }
                list.Add(obj);
            }
            return list;
        }

        // Check if a string is valid JSON
        private static bool IsValidJson(string jsonString)
        {
            try
            {
                JsonDocument.Parse(jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Modify JSON data (this function can be customized based on your needs)
        private static List<T> ModifyJsonData<T>(string jsonString, string propName)
        {
            // Example: Modify the JSON data by parsing and adding an element to an array
            using (JsonDocument doc = JsonDocument.Parse(jsonString))
            {
                JsonElement.ArrayEnumerator resultArray;
                List<T> resultList = new List<T>();

                // Access the target array
                resultArray = doc.RootElement.GetProperty(propName).EnumerateArray();
                foreach (JsonElement element in resultArray)
                {
                    // Get the string value from each element
                    resultList.Add(JsonSerializer.Deserialize<T>(element.GetRawText()));
                }
                return resultList;
            }
        }
    }

    public static class SqlDataReaderExtensions
    {
        public static bool HasColumn(this SqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}
