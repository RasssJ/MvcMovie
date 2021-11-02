using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Rating = "R",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "B",
                        Price = 3.99M
                    }
                );

                if (context.Actors.Any())
                {
                    return;   // DB has been seeded
                }

                context.Actors.AddRange(
                    new Actors
                    {
                        FirstName = "Brad",
                        LastName = "Pitt",
                        Birthday = DateTime.Parse("1989-2-12"),
                        Skill = "Beginner",
                        Birthplace = "California",
                        Networth = 5000M
                    },

                    new Actors
                    {
                        FirstName = "Al",
                        LastName = "Pacino",
                        Birthday = DateTime.Parse("1984-3-13"),
                        Birthplace = "Chicago",
                        Skill = "Intermediate",
                        Networth = 800000M
                    },

                    new Actors
                    {
                        FirstName = "Joe",
                        LastName = "Pesci",
                        Birthday = DateTime.Parse("1986-2-23"),
                        Birthplace = "New York",
                        Skill = "Expert",
                        Networth = 900000M
                    },

                    new Actors
                    {
                        FirstName = "Matt",
                        LastName = "Damon",
                        Birthday = DateTime.Parse("1959-4-15"),
                        Birthplace = "London",
                        Skill = "Legendary",
                        Networth = 30000000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
