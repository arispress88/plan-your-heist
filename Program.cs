using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Plan Your Heist!");

        Console.WriteLine("Enter a team member's name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the team member's skill level (a positive integer):");
        int skillLevel = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the team member's courage factor (a decimal between 0.0 and 2.0)");
        double courageFactor = double.Parse(Console.ReadLine());

        Console.WriteLine("\nTeam Member Information:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Skill Level: " + skillLevel);
        Console.WriteLine("Courage Factor: " + courageFactor);

        Console.ReadLine();
    }
}