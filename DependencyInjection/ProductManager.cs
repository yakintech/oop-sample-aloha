using System;
namespace DependencyInjection
{
    public class ProductManager
    {

        ILogger _logger;

        public ProductManager(ILogger logger)
        {
            this._logger = logger;
        }

        public void AddProduct(Product product)
        {
            //ürün ekleme operasyonları
            _logger.PrintLog();
        }

    }
}

