using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of players
            Player player1 = new Player(PlayerClass.Tank, "Ana");
            Player player2 = new Player(PlayerClass.Slayer, "Paulo");
            Player player3 = new Player(PlayerClass.Tank, "Ana"); // Same name and class as player1

            // Creating a HashSet collection of players and adding the instances
            HashSet<Player> setOfPlayers = new HashSet<Player>();
            setOfPlayers.Add(player1);
            setOfPlayers.Add(player2);
            setOfPlayers.Add(player3);

            // Iterating over the players and printing their names and classes
            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.PCClass}");
            }
        }
    }
}
