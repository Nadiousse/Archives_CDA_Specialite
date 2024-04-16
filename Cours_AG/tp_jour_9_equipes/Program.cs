using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_9_equipes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namesTeam1 = { "Alice", "Bob", "Charlie", "David", "Emma", "Frank" };
            string[] namesTeam2 = { "Grace", "Hannah", "Ian", "Julia", "Beta", "Philippe" };

            Team chickenTeam = new Team("Chickens", namesTeam1);
            Team gooseTeam = new Team("Gooses", namesTeam2);

            Referee.DisplayTheTwoTeams(chickenTeam, gooseTeam);

            Console.ReadLine();

            Referee.GiveTeamsPlayerACard(Card.red, chickenTeam, chickenTeam.ReturnRandomPlayer());
            Referee.RemovePlayersOrNot(chickenTeam);
            Referee.GiveTeamsPlayerACard(Card.yellow, gooseTeam, gooseTeam.ReturnRandomPlayer());
            Referee.RemovePlayersOrNot(gooseTeam);

            Console.ReadLine();

            Referee.DisplayTheTwoTeams(chickenTeam, gooseTeam);

            Console.ReadLine();
        }
    }
}
