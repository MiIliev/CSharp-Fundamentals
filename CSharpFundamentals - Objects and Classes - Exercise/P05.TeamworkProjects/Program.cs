using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace P05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teamList = CreateTeams();
            AddUsers(teamList);
            PrintResult(teamList);


            static List<Team> CreateTeams()
            {
                List<Team> teamList = new List<Team>();
                int countTeams = int.Parse(Console.ReadLine());
                for (int i = 0; i < countTeams; i++)
                {
                    List<string> input = Console.ReadLine()
                        .Split("-")
                        .ToList();
                    string creator = input[0];
                    string teamName = input[1];

                    if (teamList.Any(team => team.TeamName == teamName))
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                    }
                    else if (teamList.Any(team => team.Creator == creator))
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                    else
                    {
                        Team team = new Team(teamName, creator);
                        teamList.Add(team);
                        Console.WriteLine(team.CreateNewTeam());
                    }
                }
                return teamList;
            }
            static void AddUsers(List<Team> teamList)
            {
                string command = null;
                while ((command = Console.ReadLine()) != "end of assignment")
                {
                    List<string> input = command
                        .Split("->")
                        .ToList();
                    string user = input[0];
                    string teamName = input[1];

                    if (!(teamList.Any(team => team.TeamName == teamName)))
                    {
                        Console.WriteLine($"Team {teamName} does not exist!");
                    }
                    else if (teamList.Any(team => team.Users.Contains(user)) ||
                        teamList.Any(team => team.Creator == user))
                    {
                        Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    }
                    else
                    {
                        Team team = teamList.Find(team => team.TeamName == teamName);
                        team.Users.Add(user);
                    }
                }
            }
            static void PrintResult(List<Team> teamList)
            {
                foreach (Team team in teamList.OrderByDescending(team => team.Users.Count)
                    .ThenBy(team => team.TeamName)
                    .Where(team => team.Users.Count > 0))
                {
                    Console.WriteLine($"{team.TeamName}\n" +
                        $"- {team.Creator}");
                    foreach (string user in team.Users.OrderBy(user => user))
                    {
                        Console.WriteLine($"-- {user}");
                    }
                }
                Console.WriteLine("Teams to disband:");
                foreach (Team team in teamList.OrderBy(team => team.TeamName).Where(team => team.Users.Count == 0))
                {
                    Console.WriteLine(team.TeamName);
                }
            }

        }
    }
    public class Team
    {
        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Users = new List<string>();
        }

        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Users { get; set; }

        public string CreateNewTeam()
        {
            return $"Team {TeamName} has been created by {Creator}!";
        }

        public void AddUser(string user)
        {
            Users.Add(user);
        }
    }
}