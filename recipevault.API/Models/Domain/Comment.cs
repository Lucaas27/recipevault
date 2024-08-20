namespace recipevault.API.Models.Domain
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int CreatedAt { get; set; }
        public int UserId { get; set; } // Foreign key
        public int RecipeId { get; set; } // Foreign key

        // Navigation property
        public User User { get; set; }
        public Recipe Recipe { get; set; }


    }
}