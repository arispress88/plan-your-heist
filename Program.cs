using System;

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

            Console.WriteLine("Enter the team member's skill level (a positive integer):");
            int skillLevel = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the team member's courage factor (a decimal between 0.0 and 2.0)");
            double courageFactor = double.Parse(Console.ReadLine());

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