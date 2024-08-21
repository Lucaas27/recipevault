using recipevault.API.Interfaces;

namespace recipevault.API.Models.Domain
{
    public class Comment : ITimestampable
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; } // Foreign key
        public int RecipeId { get; set; } // Foreign key

        // Navigation property
        public User User { get; set; }
        public Recipe Recipe { get; set; }

    }
}