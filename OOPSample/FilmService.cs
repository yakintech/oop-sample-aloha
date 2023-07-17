using System;
using AngleSharp;
using HtmlAgilityPack;

namespace OOPSample
{
    public class FilmService
    {
        public static List<Film> GetFilms(int count = 50)
        {
            List<Film> filmList = new List<Film>();

            // Custom film data with directors and durations
            string[] filmNames = {
            "The Shawshank Redemption",
            "The Godfather",
            "The Dark Knight",
            "Pulp Fiction",
            "Fight Club",
            "Inception",
            "The Matrix",
            "Interstellar",
            "The Lord of the Rings: The Fellowship of the Ring",
            "Goodfellas",
            "The Godfather: Part II",
            "Forrest Gump",
            "The Empire Strikes Back",
            "The Silence of the Lambs",
            "The Usual Suspects",
            "Se7en",
            "The Avengers",
            "Schindler's List",
            "Gladiator",
            "Casablanca",
            "The Lion King",
            "The Departed",
            "The Prestige",
            "Eternal Sunshine of the Spotless Mind",
            "The Green Mile",
            "The Great Gatsby",
            "Whiplash",
            "La La Land",
            "The Social Network",
            "Blade Runner",
            "The Shawshank Redemption",
            "The Dark Knight Rises",
            "Braveheart",
            "The Godfather: Part III",
            "Inglourious Basterds",
            "Django Unchained",
            "The Wolf of Wall Street",
            "Birdman",
            "Gone Girl",
            "Mad Max: Fury Road",
            "Arrival",
            "Moonlight",
            "Get Out",
            "Baby Driver",
            "Three Billboards Outside Ebbing, Missouri",
            "Black Panther",
            "A Star Is Born",
            "Bohemian Rhapsody",
            "Parasite"
        };

            string[] directors = {
            "Frank Darabont",
            "Francis Ford Coppola",
            "Christopher Nolan",
            "Quentin Tarantino",
            "David Fincher",
            "Christopher Nolan",
            "Lana Wachowski, Lilly Wachowski",
            "Christopher Nolan",
            "Peter Jackson",
            "Martin Scorsese",
            "Francis Ford Coppola",
            "Robert Zemeckis",
            "Irvin Kershner",
            "Jonathan Demme",
            "Bryan Singer",
            "David Fincher",
            "Joss Whedon",
            "Steven Spielberg",
            "Ridley Scott",
            "Michael Curtiz",
            "Roger Allers, Rob Minkoff",
            "Martin Scorsese",
            "Christopher Nolan",
            "Michel Gondry",
            "Frank Darabont",
            "Baz Luhrmann",
            "Damien Chazelle",
            "David Fincher",
            "Ridley Scott",
            "Frank Darabont",
            "Christopher Nolan",
            "Mel Gibson",
            "Francis Ford Coppola",
            "Quentin Tarantino",
            "Martin Scorsese",
            "Alejandro G. Iñárritu",
            "David Fincher",
            "Martin Scorsese",
            "Alejandro G. Iñárritu",
            "David Fincher",
            "George Miller",
            "Denis Villeneuve",
            "Barry Jenkins",
            "Jordan Peele",
            "Edgar Wright",
            "Martin McDonagh",
            "Ryan Coogler",
            "Bradley Cooper",
            "Bryan Singer",
            "Bong Joon Ho"
        };

            int[] filmDurations = {
            142,
            175,
            152,
            154,
            139,
            148,
            136,
            169,
            178,
            146,
            202,
            142,
            124,
            118,
            106,
            127,
            143,
            195,
            155,
            102,
            88,
            151,
            130,
            108,
            189,
            143,
            143,
            106,
            120,
            117,
            142,
            164,
            177,
            146,
            187,
            152,
            180,
            120,
            149,
            120,
            118,
            160,
            110,
            104,
            135,
            115,
            134,
            134,
            150,
            132,
            132
        };

            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                int randomIndex = random.Next(filmNames.Length);
                string name = filmNames[randomIndex];
                string director = directors[randomIndex];
                int duration = filmDurations[randomIndex];

                Film film = new Film
                {
                    Id = i + 1,
                    Name = name,
                    Year = random.Next(1980, 2023), // Generates a random year between 1980 and 2022
                    Point = (decimal)random.NextDouble() * 10, // Generates a random decimal between 0 and 10
                    Director = director,
                    Time = duration
                };

                filmList.Add(film);
            }

            return filmList;
        }
    }
}

