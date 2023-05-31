﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Plan Your Heist!");

        List<TeamMember> teamMembers = new List<TeamMember>();

        while (true)
        {
            Console.WriteLine("\nEnter a team member's name (or leave blank to finish):");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                break; // Exits loop if the name is blank
            }

            int skillLevel;
            while (true)
            {
                Console.WriteLine("Enter the team member's skill level (a positive integer):");
                if (int.TryParse(Console.ReadLine(), out skillLevel) && skillLevel > 0)
                {
                    break; // Valid input, exit the loop
                }
                Console.WriteLine("Invalid input. Skill level must be a positive integer.");
            }
            
            
            double courageFactor;
            while (true)
            {
                Console.WriteLine("Enter the team member's courage factor (a decimal between 0.0 and 2.0):");
                if (double.TryParse(Console.ReadLine(), out courageFactor) && courageFactor >= 0.0 && courageFactor <= 2.0)
                {
                    break; // Valid input, exit loop
                }
                Console.WriteLine("Invalid input. Courage factor must be a decimal betwee 0.0 and 2.0.");
            }

            TeamMember teamMember = new TeamMember(name, skillLevel, courageFactor);
            teamMembers.Add(teamMember);
        }

        Console.WriteLine($"\nNumber of team members: {teamMembers.Count}");


        Console.WriteLine("\nTeam Members' Information:");
        foreach (var teamMember in teamMembers)
        {
            Console.WriteLine("Name: " + teamMember.Name);
            Console.WriteLine("Skill Level: " + teamMember.SkillLevel);
            Console.WriteLine("Courage Factor: " + teamMember.CourageFactor);
            Console.WriteLine();
        }

        
        int bankDifficultyLevel;
        while (true)
        {
            Console.WriteLine("Enter the bank's difficulty level (a positive integer):");
            if (int.TryParse(Console.ReadLine(), out bankDifficultyLevel) && bankDifficultyLevel > 0)
            {
                break; // Valid input
            }
            Console.WriteLine("Invalid input. Bank difficulty level must be a positive integer.");
        }

        int totalSkillLevel = 0;
        foreach (var teamMember in teamMembers)
        {
            totalSkillLevel += teamMember.SkillLevel;
        }

        Console.WriteLine("\nCalculating heist result...");
        if (totalSkillLevel >= bankDifficultyLevel)
        {
            Console.WriteLine("Heist Successful!");
        }
        else
        {
            Console.WriteLine("Heist Failed!");
        }

        Console.ReadLine();
    }
}

class TeamMember
{
    public string Name { get; }
    public int SkillLevel { get; }
    public double CourageFactor { get; }
    public TeamMember(string name, int skillLevel, double courageFactor)
    {
        Name = name;
        SkillLevel = skillLevel;
        CourageFactor = courageFactor;
    }
}