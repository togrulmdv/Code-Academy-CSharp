namespace class_03_10.Models;

public class User
{
    public string Username { get; set; }
    private string _password;
    public  byte Age { get; set; }
    public string Password 
    {
        get => _password; 
        set
        {
            if(PasswordCheck(value))
            {
                _password = value;
            }
        }
    }
    
    public User(string username,string password,byte age)
    {
        Username= username;
        Password= password;
    }
    private bool PasswordCheck(string password)
    {
        {
            if (!string.IsNullOrWhiteSpace(password)
                && password.Length >= 8)
            {
                bool result1 = false;
                bool result2 = false;
                bool result3 = false;

                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]))
                    { result1 = true; }
                    else if (char.IsLower(password[i]))
                    { result2 = true; }
                    else if (char.IsDigit(password[i]))
                    { result3 = true; }
                }
                if (result1 == true && result2 == true && result3 == true)
                { return true; }
                
            }
                return false;
        }
    }
}
