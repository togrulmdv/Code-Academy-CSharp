namespace Core.Entities;
public class Rectangular : Figure
{
    public byte width { get; set; }
    public byte length { get; set; }
    public Rectangular(byte width, byte length)
    {
        this.width = width;
        this.length = length;
    }
    public override int CalcArea()
    {
        return width*length;
    }
}