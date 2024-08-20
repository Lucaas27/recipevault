using recipevault.API.Interfaces;

namespace recipevault.API.Models.Domain
{
    public class Ingredient : ITimestampable
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }

        // Navigation property
        public ICollection<Recipe> Recipes { get; set; }
    }
}