namespace recipevault.API.Models.Domain
{
    public class Rating
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int RecipeId { get; set; } // Foreign key
        public int UserId { get; set; } // Foreign key

        // Navigation property
        public Recipe Recipe { get; set; }
        public User Owner { get; set; }
    }
}