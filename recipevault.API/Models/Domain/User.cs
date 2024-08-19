namespace recipevault.API.Models.Domain
{
    public class User
    {
        public int Id { get; set; }
        public int Username { get; set; }
        public int Email { get; set; }
        public int PasswordHash { get; set; }

        // Navigation properties
        public ICollection<Recipe>? RecipesCreated { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Recipe> FavouriteRecipes { get; set; }
        public ICollection<Rating> Ratings { get; set; }


    }
}