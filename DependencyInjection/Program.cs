


using DependencyInjection;

Product product = new Product();

product.Name = "IPhone";
product.Price = 5000;

ILogger logger = new DatabaseLogger();

ProductManager productManager = new ProductManager(logger);

productManager.AddProduct(product);

Console.Read();
