namespace TDD_HomeWork_Day1.model
{
    public class Product
    {
        public Product(int id,int cost,int revenue,int sellPrice)
        {
            this.Id = id;
            this.Cost = cost;
            this.Revenue = revenue;
            this.SellPrice = sellPrice;
        }
        public int Id { get; }
        public int Cost { get;  }
        public int Revenue { get; }
        public int SellPrice { get; }
    }
}
