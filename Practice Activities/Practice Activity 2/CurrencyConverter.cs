using System;

Console.Write("Enter amount in USD: ");
double usd = double.Parse(Console.ReadLine());
Console.Write("Enter exchange rate from USD TO EUR: ");
double exRate = double.Parse(Console.ReadLine());

double converted = usd * exRate;

Console.WriteLine("Amount in EUR: {0:F2}", converted);
