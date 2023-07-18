using System;
namespace OOPPrinciples
{
    public class Product : BaseModel
    {
        decimal taxRate = 1.2M;
        //constructor method - 1
        public Product()
        {
        }

        //constructor method - 2
        public Product(string name, decimal unitPrice, decimal taxRate = 1.2M)
        {
            this.Name = name;
            this.UnitPrice = unitPrice;
            this.taxRate = taxRate;
        }

        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TaxPrice { get { return UnitPrice * taxRate; } }
    }
}

