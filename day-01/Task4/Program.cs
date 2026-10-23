Console.Write("Enter a word: ");
string word = Console.ReadLine() ?? "";
Console.WriteLine($"Upper: {word.ToUpper()}");
Console.WriteLine($"Lower: {word.ToLower()}");
Console.WriteLine($"Length: {word.Length}");