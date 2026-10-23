using System.Globalization;

decimal usdRate = 41.50m;
decimal eurRate = 48.20m;

Console.Write("Enter amount in UAH: ");
decimal uah = decimal.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

decimal usd = uah / usdRate;
decimal eur = uah / eurRate;

Console.WriteLine($"{uah} UAH = {usd:F2} USD");
Console.WriteLine($"{uah} UAH = {eur:F2} EUR");