namespace _03_14_task.Models;
internal class Student
{
    private static int _id;
    public int Id { get; }
    public string FullName { get; set; }
    public int Point { get; set; }
    public Student(string fullName, int point)
    {
        _id++;
        Id = _id;
        FullName = fullName;
        Point = point;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"{FullName},{Point},{Id}");
    }
}