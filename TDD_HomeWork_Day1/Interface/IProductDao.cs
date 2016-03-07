using System.Collections.Generic;
using TDD_HomeWork_Day1.model;

namespace TDD_HomeWork_Day1.Interface
{
    public interface IProductDao
    {
        IEnumerable<Product> GetData();
    }
}