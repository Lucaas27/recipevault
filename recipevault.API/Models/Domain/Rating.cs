using recipevault.API.Interfaces;

namespace recipevault.API.Models.Domain
{
    public class Rating : ITimestampable
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Id { get; set; }
        public int Value { get; set; }
        public int RecipeId { get; set; } // Foreign key
        public int UserId { get; set; } // Foreign key

        // Navigation property
        public Recipe Recipe { get; set; }
        public User User { get; set; }
    }
}