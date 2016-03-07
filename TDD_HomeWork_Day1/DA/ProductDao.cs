using System.Collections.Generic;
using TDD_HomeWork_Day1.model;

namespace TDD_HomeWork_Day1.DA
{
    public class ProductDao 
    {
        public IEnumerable<Product> GetData()
        {
            return new List<Product>()
            {
                new Product(1,1,11,21),
                new Product(2,2,12,22),
                new Product(3,3,13,23),
                new Product(4,4,14,24),
                new Product(5,5,15,25),
                new Product(6,6,16,26),
                new Product(7,7,17,27),
                new Product(8,8,18,28),
                new Product(9,9,19,29),
                new Product(10,10,20,30),
                new Product(11,11,21,31)
            };
        }
    }
}