using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_HomeWork_Day1.model;
using TDD_HomeWork_Day1.Interface;
using NSubstitute;


namespace TDD_HomeWork_Day1_Tests.Model
{
    [TestClass]
    public class ProductSumTest
    {
        [TestMethod]
        public void Sum_Product_Cost_GroupBy3()
        {
            //arrange
            IProductDao target = Substitute.For<IProductDao>();
            target.GetData().Returns(GetProductTestData());
            int groupCnt = 3;
            var column = ProductColumn.Cost;
            var expected = new List<int> {6, 15, 24, 21};
            //act
            var actual = target.GetSum(column, groupCnt);
            //assert
            CollectionAssert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void Sum_Product_Revenue_GroupBy4()
        {
            //arrange
            IProductDao target = Substitute.For<IProductDao>();
            target.GetData().Returns(GetProductTestData());
            int groupCnt = 4;
            var column = ProductColumn.Revenue;
            var expected = new List<int> { 50, 66, 60 };
            //act
            List<int> actual = target.GetSum(column, groupCnt);
            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 單元測試使用的假資料
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Product> GetProductTestData()
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
