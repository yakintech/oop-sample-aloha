using System;
namespace OOPSample
{
    public class CountryService
    {

        public static List<Country> GenerateRandomCountries(int count = 100)
        {
            List<Country> countryList = new List<Country>();
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                Country country = new Country
                {
                    Id = i + 1,
                    Name = GenerateRandomCountryName(),
                    Population = random.Next(1000000, 1000000000) // Generates a random population between 1,000,000 and 1,000,000,000
                };

                countryList.Add(country);
            }

            return countryList;
        }

        public static string GenerateRandomCountryName()
        {
            string[] countryNames = {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czechia",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia"
            // Add more country names as needed
        };

            Random random = new Random();
            int randomIndex = random.Next(countryNames.Length);
            return countryNames[randomIndex];
        }

    }
}



//1) Country leri isme göre tersten sırala ve console a yaz
//2) Country leri isminin içerisinde w harfi geçenleri console a yaz
//3) Country leri isminin içerisinde w harfi geçen kaç adet country var?
//4) En yüksek popülasyona sahip country adı nedir?
//5) r harfi ile biten country leri ekrana yaz
//6) Id si 22 olan country adı nedir?
//7) Popülasyon 10 milyonla 50 milyon arasındaki şehirleri ekrana yaz

