namespace recipevault.API.Models.Domain
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }
        public int RecipeId { get; set; } // Foreign key

        // Navigation property
        public Recipe Recipe { get; set; }
    }
}