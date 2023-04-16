using AnyBank_ADM.Employees;

namespace AnyBank_ADM.InternalSystem;

public interface IAuthenticable
{
  public string Login { get; set; }
  public string Password { get; set; }

  bool Authenticated(string login, string password);
}