using OOP.Enums;
using OOP.Extensions;

// Days of week mde to practice csharp EXTENSIONS using some algo which allow us to switch to the prev or next day.

namespace OOP;

internal class Program
{
    static void Main(string[] args)
    {
        var sunday = EDays.SUNDAY;
        var monday = EDays.MONDAY;

        Console.WriteLine($"The day after {sunday} is : {sunday.GetNextDay()}");
        Console.WriteLine($"The day before {sunday} is : {sunday.GetPrevDay()}");

        Console.WriteLine($"The day after {monday} is : {monday.GetNextDay()}");
        Console.WriteLine($"The day before {monday} is : {monday.GetPrevDay()}");
    }
}