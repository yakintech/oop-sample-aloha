using System;
namespace OOPPrinciples
{
    public class Category : BaseModel
    {
        public Category()
        {

        }

        public Category(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}

