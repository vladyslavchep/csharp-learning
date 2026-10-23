Console.Write("Enter seconds: ");
int totalSeconds = int.Parse(Console.ReadLine()!);

int days = totalSeconds / 86400;
int hours = (totalSeconds % 86400) / 3600;
int minutes = (totalSeconds % 3600) / 60;
int seconds = totalSeconds % 60;

Console.WriteLine($"{totalSeconds} s = {hours} h {minutes} min {seconds} s");