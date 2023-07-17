using System;
namespace OOPSample
{
    public class ProductService
    {
        public static List<Product> GenerateProductData(int count = 100)
        {
            List<Product> productList = new List<Product>();
            Random random = new Random();

            string[] categoryNames = { "Electronics", "Clothing", "Books", "Home Decor", "Sports", "Beauty" };

            for (int i = 0; i < count; i++)
            {
                Category category = new Category
                {
                    Id = i + 1,
                    Name = categoryNames[random.Next(categoryNames.Length)]
                };

                Product product = new Product
                {
                    Id = i + 1,
                    Name = GenerateRandomProductName(),
                    UnitPrice = (decimal)random.Next(10, 1000) + (decimal)random.NextDouble(),
                    UnitsInStock = random.Next(0, 100),
                    Category = category
                };

                productList.Add(product);
            }

            return productList;
        }

        public static string GenerateRandomProductName()
        {
            string[] productNames = {
            "Smartphone",
            "T-shirt",
            "Novel",
            "Throw Pillow",
            "Basketball",
            "Lipstick",
            "Laptop",
            "Jeans",
            "Cookbook",
            "Candle",
            "Soccer Ball",
            "Mascara",
            "Headphones",
            "Dress",
            "Art Supplies",
            "Fitness Tracker",
            "Face Mask",
            "Watch",
            "Running Shoes",
            "Perfume"
            // Add more product names as needed
        };

            Random random = new Random();
            int randomIndex = random.Next(productNames.Length);
            return productNames[randomIndex];
        }
    }
}

