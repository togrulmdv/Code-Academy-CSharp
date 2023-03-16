using Core.Interfaces;
using Utils.Exceptions;

namespace Core.Entities;

public class User : IAccount
{
    private static int _id;
    public int ID { get; }
    public string Fullname;
    public string Email;
    private string _password;
    public string Password 
    {
        get => _password; 
        set
        {
            if (PasswordChecker(value))
            { _password = value; }
            else
            { throw new IncorrectPasswordException("Invalid password"); }
        }
    }
    public User(string fullname,string email,string password)
    {
        ID = ++_id;
        Fullname= fullname;
        Email = email;
        Password = password;
    }

    public bool PasswordChecker(string password)
    {
        if (!string.IsNullOrWhiteSpace(password)
                && password.Length >= 8)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                { hasUpper = true; }
                else if (char.IsLower(password[i]))
                { hasLower = true; }
                else if (char.IsDigit(password[i]))
                { hasDigit = true; }
            }
            if (hasUpper == true && hasLower == true && hasDigit == true)
            { return true; }

        }
        return false;
        //throw new IncorrectPasswordException("Invalid password");
    }

    public string ShowInfo()
    {
        return $"ID:{ID} - Fullname:{Fullname} - Email:{Email}";
    }
}
