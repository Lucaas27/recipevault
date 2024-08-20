namespace recipevault.API.Models.Domain
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CookingTime { get; set; }
        public int Servings { get; set; }
        public string ImageUrl { get; set; }

        public int UserId { get; set; } // Foreign Key for the owner of the recipe
        public User Owner { get; set; } // Navigation Property - Recipe has one owner
        public ICollection<User> FavouritedBy { get; set; }


        public int CategoryId { get; set; } // Foreign Key for the category of the recipe
        public Category Category { get; set; } // Recipe has one category

        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<Rating> Ratings { get; set; }


    }
}