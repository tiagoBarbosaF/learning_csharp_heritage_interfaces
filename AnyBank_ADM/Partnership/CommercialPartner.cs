using AnyBank_ADM.InternalSystem;

namespace AnyBank_ADM.Partnership;

public class CommercialPartner : IAuthenticable
{
  public string Login { get; set; }
  public string Password { get; set; }

  public CommercialPartner(string login, string password)
  {
    Login = login;
    Password = password;
  }

  public bool Authenticated(string login, string password)
  {
    return Login == login && Password == password;
  }
}