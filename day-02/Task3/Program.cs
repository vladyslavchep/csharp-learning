using System.Globalization;

Console.Write("Enter temperature in Celsius: ");
double celsius = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

double fahrenheit = celsius * 9 / 5 + 32;
double kelvin = celsius + 273.15;

Console.WriteLine($"{celsius} C = {fahrenheit:F2} F");
Console.WriteLine($"{celsius} C = {kelvin:F2} K");