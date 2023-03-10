namespace task_03_10.Models;

public class Person
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set
        {
            if (value.Length >= 3 && value.Length <= 30)
            {
                _name = value;
            }
            else
            { _name = "wrong length"; }
            value = char.ToUpper(value[0]) + value.Substring(1);
            _name = value;
        }
    }
    private string _surname;
    public string Surname
    {
        get { return _surname; }
        set
        { 
            if (value.Length >= 3 && value.Length <= 35)
            {
                _surname = value;
            }
            else
            { _surname = "wrong length"; }
            value = char.ToUpper(value[0]) + value.Substring(1);
            _surname= value;
        }
    }
    public byte age { get; set; }
    public Person(string Name, string Surname, byte age)
    {
        Name; //bu hisseni ede bilmedim
        Surname; //bu hisseni ede bilmedim
        this.age = age;
    }
}    
