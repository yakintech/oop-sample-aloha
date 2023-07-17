using System;
namespace OOPSample
{
    public class CityService
    {
        public static List<City> GenerateRandomCities(int count = 100)
        {
            List<City> cityList = new List<City>();
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                City city = new City
                {
                    Id = i + 1,
                    Name = GenerateRandomCityName(),
                    Population = random.Next(100000, 10000000) // Generates a random population between 100,000 and 10,000,000
                };

                cityList.Add(city);
            }

            return cityList;
        }

        public static string GenerateRandomCityName()
        {
            string[] cityNames = {
            "New York",
            "Los Angeles",
            "Chicago",
            "Houston",
            "Phoenix",
            "Philadelphia",
            "San Antonio",
            "San Diego",
            "Dallas",
            "San Jose",
            "Austin",
            "Jacksonville",
            "San Francisco",
            "Indianapolis",
            "Seattle",
            "Denver",
            "Washington",
            "Boston",
            "El Paso",
            "Nashville",
            "Detroit",
            "Portland",
            "Las Vegas",
            "Oklahoma City",
            "Memphis",
            "Louisville",
            "Baltimore",
            "Milwaukee",
            "Albuquerque",
            "Tucson",
            "Fresno",
            "Mesa",
            "Sacramento",
            "Atlanta",
            "Kansas City",
            "Colorado Springs",
            "Miami",
            "Raleigh",
            "Omaha",
            "Long Beach",
            "Virginia Beach",
            "Oakland",
            "Minneapolis",
            "Tulsa",
            "Arlington",
            "Tampa",
            "New Orleans",
            "Wichita",
            "Bakersfield",
            "Cleveland",
            "Aurora"
        };

            Random random = new Random();
            int randomIndex = random.Next(cityNames.Length);
            return cityNames[randomIndex];
        }
    }
}

