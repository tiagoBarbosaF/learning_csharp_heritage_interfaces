using AnyBank_ADM.Employees;
using AnyBank_ADM.InternalSystem;
using AnyBank_ADM.Partnership;
using AnyBank_ADM.Utils;

#region First test
ManageBonification management = new ManageBonification();
Director director = new Director("Maria", "22222222222","maria","123");
double bonification1 = director.GetBonification();
double biannualPremium1 = director.BiannualPremium();
management.Record(director);
Console.WriteLine($"\nEmployee: {director.Name}" +
                  $"\nResponsibility: {director.Responsibility}" +
                  $"\nSalary: {director.Salary}" +
                  $"\nBonification: {bonification1:F}" +
                  $"\nBiannual Premium: {biannualPremium1:F}");

Designer designer = new Designer("Paul", "33333333333");
double bonification2 = designer.GetBonification();
double biannualPremium2 = designer.BiannualPremium();
management.Record(designer);
Console.WriteLine($"\nEmployee: {designer.Name}" +
                  $"\nResponsibility: {designer.Responsibility}" +
                  $"\nSalary: {designer.Salary}" +
                  $"\nBonification: {bonification2:F}" +
                  $"\nBiannual Premium: {biannualPremium2:F}");

AccountManager accountManager = new AccountManager("Bob", "444444444444","bob","456");
double bonification3 = accountManager.GetBonification();
double biannualPremium3 = accountManager.BiannualPremium();
management.Record(accountManager);
Console.WriteLine($"\nEmployee: {accountManager.Name}" +
                  $"\nResponsibility: {accountManager.Responsibility}" +
                  $"\nSalary: {accountManager.Salary}" +
                  $"\nBonification: {bonification3:F}" +
                  $"\nBiannual Premium: {biannualPremium3:F}");

Assistant assistant = new Assistant("John", "55555555555");
double bonification4 = assistant.GetBonification();
double biannualPremium4 = assistant.BiannualPremium();
management.Record(assistant);
Console.WriteLine($"\nEmployee: {assistant.Name}" +
                  $"\nResponsibility: {assistant.Responsibility}" +
                  $"\nSalary: {assistant.Salary}" +
                  $"\nBonification: {bonification4:F}" +
                  $"\nBiannual Premium: {biannualPremium4:F}");

void IncreaseSalary()
{
  director.IncreaseSalary();
  designer.IncreaseSalary();
  accountManager.IncreaseSalary();
  assistant.IncreaseSalary();
}

IncreaseSalary();

Console.WriteLine($"\nEmployees:");
Console.WriteLine($"Director: {director.Name} - New Salary: {director.Salary:F}");
Console.WriteLine($"Designer: {designer.Name} - New Salary: {designer.Salary:F}");
Console.WriteLine($"Account Manager: {accountManager.Name} - New Salary: {accountManager.Salary:F}");
Console.WriteLine($"Assistant: {assistant.Name} - New Salary: {assistant.Salary:F}");
Console.WriteLine($"\nTotal employees: {Employee.TotalEmployees}");
Console.WriteLine($"Total bonifications: {management.TotalBonification:F}");

#endregion


#region Second test

void CheckAuthentication()
{
  Director director1 = new Director("Bia", "11111111111", "bia", "123");
  AccountManager accountManager1 = new AccountManager("Bob", "22222222222", "bob", "456");
  CommercialPartner commercialPartner = new CommercialPartner("Maria","789");

  InternalSystem internalSystem = new InternalSystem();

  internalSystem.LogInto(director1, "bia", "123");
  internalSystem.LogInto(accountManager1, "bob", "987");
  internalSystem.LogInto(commercialPartner, "Maria", "789");
}

CheckAuthentication();
#endregion
