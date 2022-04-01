using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Welcome to Créme de la Drème. Please begin by stating your name.");
            string playerName = Console.ReadLine();

            // Prompt user if they'd like to start playing
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);

            if(Console.ReadLine().ToLower() == "yes")
            {
                Player player = new Player(playerName);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            // End
            Console.WriteLine("Feel free to look around. See you soon!");
            Console.Read();
        }
        
    }
}
