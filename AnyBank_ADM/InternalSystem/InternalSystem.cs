using AnyBank_ADM.Employees;

namespace AnyBank_ADM.InternalSystem;

public class InternalSystem
{
  public bool LogInto(IAuthenticable employee, string login, string password)
  {
    bool authenticatedUser = employee.Authenticated(login, password);

    if (authenticatedUser)
    {
      Console.WriteLine("Welcome to the system.");
      return true;
    }
    else
    {
      Console.WriteLine("Wrong login or password.");
      return false;
    }
  }
}