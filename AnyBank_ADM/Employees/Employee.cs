using AnyBank_ADM.Interfaces;

namespace AnyBank_ADM.Employees;

public abstract class Employee : IBonification
{
  public string Name { get; private set; }
  public string Cpf { get; private set; }
  public string Responsibility { get; protected set; }
  public double Salary { get; protected set; }
  public static int TotalEmployees { get; private set; }

  protected Employee(string name, string cpf, string responsibility, double salary)
  {
    Name = name;
    Cpf = cpf;
    Responsibility = responsibility;
    Salary = salary;
    TotalEmployees++;
  }

  public abstract double GetBonification();

  public virtual double BiannualPremium()
  {
    return Salary * 0.20;
  }

  public abstract void IncreaseSalary();
}