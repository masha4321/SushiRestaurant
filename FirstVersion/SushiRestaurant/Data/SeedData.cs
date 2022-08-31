using Microsoft.EntityFrameworkCore;
using SushiRestaurant.Models;

namespace SushiRestaurant.Data
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider, string testUserPw = "")
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                SeedDB(context, testUserPw);
            }
        }
        public static void SeedDB(ApplicationDbContext context, string adminID)
        {
            if (context.Category.Any())
            {
                return;   // DB has been seeded
            }

            context.Category.AddRange(
                new Category
                {
                    Name = "Main Dishes"
                });
            context.SaveChanges();
        }
    }
}
