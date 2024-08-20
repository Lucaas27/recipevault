using recipevault.API.Interfaces;

namespace recipevault.API.Models.Domain
{
    public class User : ITimestampable
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        // Navigation properties
        public ICollection<Recipe>? RecipesCreated { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Recipe> FavouriteRecipes { get; set; }
        public ICollection<Rating> Ratings { get; set; }
    }
}