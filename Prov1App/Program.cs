using System;

namespace Prov1App
{
    class Program
    {

        static void Main(string[] args)
        {
            int shipLocation = 6;
            int Miss;
            int Bullets = 10;

            string playerInput;
            int playerGuess;
            Boolean enemyShipAlive = true;
            Start();

            while (Bullets > 0)
            {
                if (enemyShipAlive == true)
                {
                    playerInput = Console.ReadLine();
                    Console.Clear();
                    playerGuess = int.Parse(playerInput);
                    Miss = shipLocation - playerGuess;

                    if (playerGuess > 0 && playerGuess < 11)
                    {
                        if (playerGuess == shipLocation)
                        {
                            enemyShipAlive = false;
                            Bullets = 1;
                        }
                        else
                        {
                            Console.WriteLine("We missed by" + Miss);
                            Bullets--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Thats not a valid cordenate captain, try again");
                    }
                }
                else
                {
                    Win();
                }
            }
        }
        static void Start()
        {

            Console.WriteLine("Welcome to battle ships, lets sink the enemy ship! Press a key if you are ready");
            Console.ReadKey();
            Console.WriteLine("There is a big enemy aircraft carrier infront of us on our raidar, but we don't have its exact location. What do we do Captain?");
            Console.WriteLine("Choose where to shot (by guessing between 1-10)");
        }
        static void Win()
        {

            string playAgainInput;

            Console.WriteLine("You Sinked the ship and won Congratualtions");
            Console.WriteLine("Play Again? (y) yes (n) for no");
            playAgainInput = Console.ReadLine();

        }
    }
}

