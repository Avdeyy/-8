// See https://aka.ms/new-console-template for more information
using System;
using Практическая__8;

GentleSmartphone s1 = new GentleSmartphone(); s1.Sensor.Sensitivity = 5.0; s1.SerialNumber = 1;
GentleSmartphone s2 = new GentleSmartphone(); s2.Sensor.Sensitivity = 5.0; s2.SerialNumber = 2;
GentleSmartphone s3 = new GentleSmartphone(); s3.Sensor.Sensitivity = 5.0; s3.SerialNumber = 3;
GentleSmartphone s4 = new GentleSmartphone(); s4.Sensor.Sensitivity = 5.0; s4.SerialNumber = 4;
GentleSmartphone s5 = new GentleSmartphone(); s5.Sensor.Sensitivity = 5.0; s5.SerialNumber = 5;
GentleSmartphone s6 = new GentleSmartphone(); s6.Sensor.Sensitivity = 5.0; s6.SerialNumber = 6;

Customer c1 = new Customer(); c1.FullName = "Александров П.Т."; c1.GentelRate = 3.0;
Customer c2 = new Customer(); c2.FullName = "Иванов М.О."; c2.GentelRate = 4.0;
Customer c3 = new Customer(); c3.FullName = "Шкурин И.В."; c3.GentelRate = 7.0;
Customer c4 = new Customer(); c4.FullName = "Тётушкин Ч.Р."; c4.GentelRate = 11.0;
Customer c5 = new Customer(); c5.FullName = "Суботний Л.Л."; c5.GentelRate = 2.0;

Factory fact = new Factory();

fact.Customers.Add(c1);
fact.Customers.Add(c2);
fact.Customers.Add(c3);
fact.Customers.Add(c4);
fact.Customers.Add(c5);

fact.Smartphones.Add(s1);
fact.Smartphones.Add(s2);
fact.Smartphones.Add(s3);
fact.Smartphones.Add(s4);   
fact.Smartphones.Add(s5);
//fact.Smartphones.Add(s5);

Console.WriteLine("Пользователи:");
for (int i = 0; i < fact.Customers.Count; i++)
{
    Console.WriteLine(fact.Customers[i].FullName + ", уровень нежности: " + fact.Customers[i].GentelRate);
}

Console.WriteLine("\nСмартфоны:");
for (int i = 0; i < fact.Smartphones.Count; i++)
{
    Console.WriteLine("Смартфон №" + fact.Smartphones[i].SerialNumber + ", уровень чувствительности: " + fact.Smartphones[i].Sensor.Sensitivity);
}
Console.WriteLine("");

Console.WriteLine(fact.SaleSmartphone());

Console.WriteLine("\nПользователи оставшиеся без смартфонов:");
for (int i = 0; i < fact.Customers.Count; i++)
{
    Console.WriteLine(fact.Customers[i].FullName + ", уровень нежности: " + fact.Customers[i].GentelRate);
}

Console.WriteLine("\nСмартфоны оставшиеся без пользователей:");
for (int i = 0; i < fact.Smartphones.Count; i++)
{
    Console.WriteLine("Смартфон №" + fact.Smartphones[i].SerialNumber + ", уровень чувствительности: " + fact.Smartphones[i].Sensor.Sensitivity);
}