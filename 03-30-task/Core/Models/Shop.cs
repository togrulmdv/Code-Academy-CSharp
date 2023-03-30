namespace Core.Models;

public class Shop
{
	private List<Order> _orders;
	public Shop()
	{
		_orders = new List<Order>();
	}

	public void AddOrder(Order obj)
	{
		_orders.Add(obj);
	}

	public decimal GetOrdersAvg()
	{
		decimal sum = 0;
		for(int i=0;i< _orders.Count;i++) 
		{
			sum += _orders[i].TotalAmount;
		}
		return sum/_orders.Count;
	}

	public void RemoveOrderByNo(int no)
	{
		for(int i=0;i<_orders.Count;i++) 
		{
			if (_orders[i].No == no) 
			{
				_orders.RemoveAt(i);
			}
		}
	}
	
	public List<Order> FilterOrderByPrice(int minPrice, int maxPrice)
	{
		List<Order> filteredorders = new List<Order>();
		for(int i=0;i<_orders.Count;i++)
		{
			if (_orders[i].TotalAmount >= minPrice && _orders[i].TotalAmount <= maxPrice)
				filteredorders.Add(_orders[i]);
		}
		return filteredorders;
	}
}
