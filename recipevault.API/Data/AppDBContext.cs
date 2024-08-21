using Microsoft.EntityFrameworkCore;
using recipevault.API.Models.Domain;

namespace recipevault.API.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the one-to-many relationship between User and Recipe
            modelBuilder.Entity<Recipe>()
                .HasOne(r => r.User)  // Recipe has one Owner
                .WithMany(u => u.RecipesCreated)  // User can create many Recipes
                .HasForeignKey(r => r.UserId)  // The foreign key in the Recipe entity
                .OnDelete(DeleteBehavior.Cascade);  // Optional: Cascade delete

            // Configure the many-to-many relationship
            modelBuilder.Entity<User>()
                .HasMany(u => u.FavouriteRecipes)
                .WithMany(r => r.FavouritedBy)
                .UsingEntity<Dictionary<string, object>>(
                    "UserFavourite", // The name of the join table
                    j => j.HasOne<Recipe>().WithMany().HasForeignKey("RecipeId"),
                    j => j.HasOne<User>().WithMany().HasForeignKey("UserId")
                );

            modelBuilder.Entity<Recipe>()
                .HasMany(r => r.Ingredients)
                .WithMany(i => i.Recipes)
                .UsingEntity<Dictionary<string, object>>(
                    "RecipeIngredient", // The name of the join table
                    j => j.HasOne<Ingredient>().WithMany().HasForeignKey("IngredientId"),
                    j => j.HasOne<Recipe>().WithMany().HasForeignKey("RecipeId")
                );


        }
    }
}