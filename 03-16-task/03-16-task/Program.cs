using Core.Entities;
using Utils.Exceptions;

//User user2 = new("Musa", "musa@gmail.com", "123Qw789");

try
{
    User user1 = new("Togrul","togrul@gmail.com","1Qweiop9");
}
catch (IncorrectPasswordException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}