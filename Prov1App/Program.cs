using System;

namespace Prov1App
{
    class Program
    {

        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {

            Console.WriteLine("Welcome to battle ships, lets sink the enemy ship!");
            Console.WriteLine("There is a big enemy aircraft carrier infront of us on our raidar, but we don't have its exact location. What do we do Captain?");
            Console.WriteLine("Choose where to shot (by guessing between 1-10)");
            PlayGame();
        }
        static void Win()
        {

            string playAgainInput;

            Console.WriteLine("You Sinked the ship and won Congratualtions");
            Console.WriteLine("Play Again? (y) yes (n) for no");
            playAgainInput = Console.ReadLine();
            if (playAgainInput == "y")
            {
                Start();
            }

        }
        static void PlayGame()
        {
            int shipLocation = 6;
            int miss;

            string playerInput;
            int playerGuess = 0;

            while (true)
            {
                playerInput = Console.ReadLine();
                Console.Clear();
                try
                {
                    playerGuess = int.Parse(playerInput);
                }
                catch (System.Exception)
                {
                    //Console.WriteLine("Thats not a valid cordenate captain, try again (Guess between 1-10)");
                }
                miss = shipLocation - playerGuess;

                if (playerGuess > 0 && playerGuess < 11)
                {
                    if (playerGuess == shipLocation)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("We missed by: " + Math.Abs(miss));
                        Console.WriteLine("Shoot another shot! (Guess between 1-10)");
                    }
                }
                else
                {
                    Console.WriteLine("Thats not a valid cordenate captain, try again (Guess between 1-10)");

                }
            }
            Win();
        }
    }
}

