namespace recipevault.API.Models.Domain
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }

        // Navigation property
        public List<Recipe> Recipes { get; set; }
    }
}