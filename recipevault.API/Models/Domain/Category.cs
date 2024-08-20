using recipevault.API.Interfaces;

namespace recipevault.API.Models.Domain
{
    public class Category : ITimestampable
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Id { get; set; }
        public string Name { get; set; } // e.g., "Dessert", "Main Course"

        public ICollection<Recipe> Recipes { get; set; }


    }
}