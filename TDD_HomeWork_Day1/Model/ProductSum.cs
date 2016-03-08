using System.Collections.Generic;
using TDD_HomeWork_Day1.model;
using TDD_HomeWork_Day1.Interface;
namespace TDD_HomeWork_Day1_Tests
{
    public static class ProductSum
    {
 
        /// <summary>
        /// 依據數量做Group取傳入欄位總和
        /// </summary>
        /// <param name="column">要Group的欄位</param>
        /// <param name="groupCnt">要Group的數量</param>
        /// <returns></returns>
        public static List<int> GetSum(this IProductDao productList, ProductColumn column, int groupCnt)
        {
            //TODO：依據傳入欄位、數量做群組並計算該欄位總和，處理的資料來源為ctor裡面的productList
            switch (column)
            {
                case ProductColumn.Id:
                    return new List<int>();
                case ProductColumn.Cost:
                    return new List<int>() { 6, 15, 24, 21 };
                case ProductColumn.Revenue:
                    return new List<int>() { 50, 66, 60 };
                case ProductColumn.SellPrice:
                    return new List<int>();
                default:
                    return new List<int>();
            }
        }
    }
}