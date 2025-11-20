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
    internal class Collection
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("gameids")]
        public List<int> GameIds { get; set; }

        public Collection(string name)
        {
            Name = name.Trim().ToLower();
            GameIds = new List<int>();
        }
    }
}
