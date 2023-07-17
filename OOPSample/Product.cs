using System;
namespace OOPSample
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public Category Category { get; set; }
    }

}

