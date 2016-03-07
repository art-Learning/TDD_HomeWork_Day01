using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_HomeWork_Day1.DA;
using TDD_HomeWork_Day1.model;

namespace TDD_HomeWork_Day1_Tests.Model
{
    [TestClass]
    public class ProductSumTest
    {
        [TestMethod]
        public void Sum_Product_Cost_GroupBy3()
        {
            //arrange
            var productList = new ProductDao().GetData(); 
            var target = new ProductSum(productList);
            int groupCnt = 3;
            var colume = ProductColume.Cost;
            var expected = new List<int> {6, 15, 24, 21};
            //act
            var actual = target.GetSum(colume, groupCnt);
            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_Product_Revenue_GroupBy4()
        {
            //arrange
            var productList = new ProductDao().GetData();
            var target = new ProductSum(productList);
            int groupCnt = 4;
            var colume = ProductColume.Revenue;
            var expected = new List<int> { 50, 66, 60 };
            //act
            List<int> actual = target.GetSum(colume, groupCnt);
            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
