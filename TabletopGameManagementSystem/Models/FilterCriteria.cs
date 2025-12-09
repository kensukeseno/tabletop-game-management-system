
namespace TabletopGameManagementSystem.Models
{
    public class FilterCriteria
    {
        public string NameContains { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }

        public int PlayingTime { get; set; }

        public int AgeSuitability { get; set; }

        public bool IsWishlisted { get; set; }
        public bool IsOwned { get; set; }
        public bool IsFavorite { get; set; }
        public List<string> Categories { get; set; } = new List<string>();

        public bool IsIdentical(FilterCriteria other)
        {
            if (other == null) return false;

            bool categoriesEqual = (Categories == null && other.Categories == null)
                || (Categories != null && other.Categories != null && Categories.SequenceEqual(other.Categories));

            return NameContains == other.NameContains &&
                   MinPlayers == other.MinPlayers &&
                   MaxPlayers == other.MaxPlayers &&
                   PlayingTime == other.PlayingTime &&
                   AgeSuitability == other.AgeSuitability &&
                   IsWishlisted == other.IsWishlisted &&
                   IsOwned == other.IsOwned &&
                   IsFavorite == other.IsFavorite &&
                   categoriesEqual;
        }


    }
}

