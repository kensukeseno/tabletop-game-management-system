namespace TabletopGameManagementSystem.Models
{
    public class SelectorCriteria
    {
        public int? PlayerCount { get; set; }
        public int? AgeSuitability { get; set; }
        public int? PlayingTime { get; set; }

        public List<string> Categories { get; set; } = new();
        public List<string> SelectedCollections { get; set; } = new();

        public int NumberOfGames { get; set; } = 1;

        public bool OwnedOnly { get; set; } = true;
    }
}

