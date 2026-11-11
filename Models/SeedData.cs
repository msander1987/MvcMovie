using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
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
                   ReleaseDate = DateTime.Parse("1989-1-11"),
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
                    Rating = "PG",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "PG-13",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Lord of the Rings",
                    ReleaseDate = DateTime.Parse("2001-12-21"),
                    Genre = "Fantasy",
                    Rating = "PG-13",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Avengers End Game",
                    ReleaseDate = DateTime.Parse("2019-04-15"),
                    Genre = "Fantasy",
                    Rating = "PG-13",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "The Help",
                    ReleaseDate = DateTime.Parse("2011-08-10"),
                    Genre = "Drama",
                    Rating = "PG-13",
                    Price = 11.99M
                }
            );
            context.SaveChanges();
        }
    }
}