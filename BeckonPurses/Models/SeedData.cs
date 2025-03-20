using BeckonPurses.Models;
using Microsoft.EntityFrameworkCore;

namespace BeckonPurses.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BeckonPursesContext(
                serviceProvider.GetRequiredService<DbContextOptions<BeckonPursesContext>>()))
            {
                // Look for any purses.
                if (context.Purse.Any())
                {
                    return;   // DB has been seeded
                }

                context.Purse.AddRange(
                    new Purse
                    {
                        Material = "Leather",
                        Size = "Medium",
                        Shape = "Tote",
                        Color = "Black",
                        Texture = "Smooth",
                        ClosureType = "Zipper",
                        Price = 99.99M
                    },
                    new Purse
                    {
                        Material = "Canvas",
                        Size = "Small",
                        Shape = "Crossbody",
                        Color = "Red",
                        Texture = "Matte",
                        ClosureType = "Magnetic",
                        Price = 49.99M
                    },
                    new Purse
                    {
                        Material = "Suede",
                        Size = "Large",
                        Shape = "Hobo",
                        Color = "Brown",
                        Texture = "Textured",
                        ClosureType = "Button",
                        Price = 129.99M
                    },
                    new Purse
                    {
                        Material = "Vegan Leather",
                        Size = "Medium",
                        Shape = "Clutch",
                        Color = "Mahogany",
                        Texture = "Smooth",
                        ClosureType = "Magnetic",
                        Price = 69.99M
                    },
                    new Purse
                    {
                        Material = "Denim",
                        Size = "Large",
                        Shape = "Tote",
                        Color = "Blue",
                        Texture = "Ribbed",
                        ClosureType = "Zipper",
                        Price = 59.99M
                    }


                );
                context.SaveChanges();
            }
        }
    }
}
