namespace Core.Models;

public class Order
{
    public int No { get; set; }
    public int ProductCount { get; set; }
    public decimal TotalAmount { get; set; }
    public Order(int no, int productCount, int totalAmount)
    {
        No = no;
        ProductCount = productCount;
        TotalAmount = totalAmount;
    }
}
