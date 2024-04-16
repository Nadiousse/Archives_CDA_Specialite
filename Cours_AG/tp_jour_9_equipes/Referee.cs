using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_9_equipes
{
    internal class Referee
    {
        static public void GiveTeamsPlayerACard(Card card, Team team, Player targetedPlayer)
        {
            foreach (Player player in team.CurrentPlayersList)
            {
                if (player == targetedPlayer)
                {
                    player.CardsList.Add(card);
                }
            }
        }

        static public int CountCardsPerPlayer(Player player, Card TargettedCard)
        {
            int recurrence = 0;

            foreach (Card card in player.CardsList)
            {
                if (card == TargettedCard)
                {
                    recurrence++;
                }
            }

            return recurrence;
        }

        static public void RemovePlayersOrNot(Team team)
        {
            foreach (Player player in team.CurrentPlayersList)
            {
                bool removeConditionRedCard = player.CardsList.Contains(Card.red);
                bool removeConditionYellowCard = (CountCardsPerPlayer(player, Card.yellow) == 2);

                if (removeConditionRedCard || removeConditionYellowCard)
                {
                    team.CurrentPlayersList.Remove(player);

                    Console.WriteLine($"Le joueur {player} a été enlevé du match.");
                    break;
                }
            }
        }

        static public void DisplayTheTwoTeams(Team team1, Team team2)
        {
            Team[] teamsList =
            {
                team1,
                team2
            };

            for (int i = 0; i < 2; i++) 
            {
                foreach (Player player in teamsList[i].CurrentPlayersList)
                {
                    Console.Write("- " + player.Name);
                    
                    if (player.CardsList.Contains(Card.yellow))
                    {
                        Console.WriteLine(" (carton Jaune = 1)");
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }

                Console.WriteLine("------------------------------------");
            }
        }
    }
}
