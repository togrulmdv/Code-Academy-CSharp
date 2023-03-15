namespace Core.Entities; 
public class Square : Figure
{
    public byte side { get; set; }
	public Square(byte side)
	{
		this.side = side;
	}
public override int CalcArea()
    {
        return side*side;
    }
}