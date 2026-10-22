Console.Write("Enter a city: ");
string city = Console.ReadLine() ?? "";
Console.Write("Enter an animal: ");
string animal = Console.ReadLine() ?? "";
Console.Write("Enter a color: ");
string color = Console.ReadLine() ?? "";
Console.WriteLine($"In {city} lives a {color} {animal}");
Console.WriteLine($"Every morning the {animal} says: \"I love C#!\"");