using AnyBank_ADM.InternalSystem;

namespace AnyBank_ADM.Employees;

public abstract class EmployeeAuthenticable : Employee, IAuthenticable
{
  public string Login { get; set; }
  public string Password { get; set; }

  protected EmployeeAuthenticable(string name, string cpf, string responsibility, double salary, string login, string password) : base(name, cpf,
    responsibility, salary)
  {
    Login = login;
    Password = password;
  }

  public bool Authenticated(string login, string password)
  {
    return Login == login && Password == password;
  }
}