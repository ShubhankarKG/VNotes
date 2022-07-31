using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace VNotes.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VNotesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VNotesContext>>()))
            {
                // Look for any movies.
                if (context.Note.Any())
                {
                    return;   // DB has been seeded
                }

                context.Note.AddRange(
                    new VNotes.Models.Note
                    {
                        Title = "When Harry Met Sally",
                        CreatedAt = DateTime.Parse("1989-2-12"),
                        Description = "Romantic Comedy",
                    },

                    new VNotes.Models.Note
                    {
                        Title = "Ghostbusters ",
                        CreatedAt = DateTime.Parse("1984-3-13"),
                        Description = "Comedy",
                    },

                    new VNotes.Models.Note

                    {
                        Title = "Ghostbusters 2",
                        CreatedAt = DateTime.Parse("1986-2-23"),
                        Description = "Comedy",
                    },

                    new VNotes.Models.Note

                    {
                        Title = "Rio Bravo",
                        CreatedAt = DateTime.Parse("1959-4-15"),
                        Description = "Western",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}