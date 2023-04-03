using Core.Models;

try
{
    MyList<int> menimlistim = new MyList<int>();
    menimlistim.Add(1);
    menimlistim.Add(2);
    menimlistim.Add(3);
    menimlistim.Add(4);
    menimlistim.Add(5);
    menimlistim.Add(6);
    menimlistim.Add(7);
    menimlistim.Add(8);

    Console.WriteLine(menimlistim[1]);

    Console.WriteLine(menimlistim.Contains(9));

    Console.WriteLine(menimlistim.Exists(x => x < 0));

    Console.WriteLine(menimlistim.Find(x => x > 2 && x < 5));

    foreach (var item in menimlistim.FindAll(x => x > 3))
    {
        Console.WriteLine(item);
    }

    Console.WriteLine(menimlistim.FindIndex(x => x > 5));

    Console.WriteLine(menimlistim.IndexOf(3));

    Console.WriteLine(menimlistim.Remove(5));

    menimlistim.Reverse();
    foreach(var item in menimlistim)
    {
        Console.WriteLine(item);
    }
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


//List<int> menimlistim = new List<int>();
//menimlistim.Add(0);
//menimlistim.Add(1);
//menimlistim.Add(2);
//menimlistim.Add(3);
//menimlistim.Add(4);
//menimlistim.Add(5);
//menimlistim.Add(6);
//menimlistim.Add(7);
//menimlistim.Add(8);
//menimlistim.Add(9);

//Console.WriteLine(menimlistim.Find(x => x > 2 && x < 5));
//foreach (var item in menimlistim.FindAll(x => x > 0))
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine(menimlistim.Remove(-1));
//List