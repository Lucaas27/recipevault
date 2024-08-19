namespace recipevault.API.Models.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } // e.g., "Dessert", "Main Course"

        public ICollection<Recipe>? Recipes { get; set; }


    }
}