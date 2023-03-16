namespace Core.Interfaces;

public interface IAccount
{
    bool PasswordChecker(string password);
    string ShowInfo();
}
