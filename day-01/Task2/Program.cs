Console.Write("What is your name? ");
string name = Console.ReadLine() ?? "";
Console.WriteLine($"Hello, {name}! Welcome to C#.");
Console.Write("Where are you from? ");
string city = Console.ReadLine() ?? "";
Console.WriteLine($"{city}is a great place to learn programming!");