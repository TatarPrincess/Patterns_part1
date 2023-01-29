
using HW_17._6._6;

SalaryAccount salaryAccount = new SalaryAccount("Зарплатный", 1200.00);
var salaryAccountInterest = Calculator.CalculateInterest(salaryAccount);
Console.WriteLine($"Процент на остаток на зарплатном счете - {salaryAccountInterest}");

OrdinaryAccount ordinaryHighRestAccount = new OrdinaryAccount("Обычный", 60000.00);
var ordinaryHighRestAccountInterest = Calculator.CalculateInterest(ordinaryHighRestAccount);
Console.WriteLine($"Процент на остаток на обычном счете с большим остатком - {ordinaryHighRestAccountInterest}");

OrdinaryAccount ordinaryMiddleRestAccount = new OrdinaryAccount("Обычный", 49000.00);
var ordinaryMiddleRestAccountInterest = Calculator.CalculateInterest(ordinaryMiddleRestAccount);
Console.WriteLine($"Процент на остаток на обычном счете средним остатком - {ordinaryHighRestAccountInterest}");

OrdinaryAccount ordinaryLowRestAccount = new OrdinaryAccount("Обычный", 500.00);
var ordinaryLowRestAccountInterest = Calculator.CalculateInterest(ordinaryLowRestAccount);
Console.WriteLine($"Процент на остаток на обычном счете с маленьким остатком - {ordinaryLowRestAccountInterest}");

