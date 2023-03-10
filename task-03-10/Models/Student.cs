namespace task_03_10.Models;

public class Student:Person
{
    private byte _point;
    public byte Point
    {
        get { return _point; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                _point = value;
            }
            else
            {
                _point = 0;
            }
        }
    }
    public Student(string NameDetermine, string SurnameDetermine, byte age, byte PointDetermine) : base(NameDetermine, SurnameDetermine, age)
    {
        Point= PointDetermine;
    }
}
    





