using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random();
            int valueToGuess = rndm.Next(1,21);
            Console.WriteLine("Guess a number from 1 to 20");
            String s = Console.ReadLine();
            int value = Convert.ToInt32(s);
            while (value != valueToGuess)
            {
                Console.WriteLine("Oops, this is not my value");
                if (value > valueToGuess)
                {
                    Console.WriteLine("Your value is greater than mine, try again");
                }
                else Console.WriteLine("Your value is lower than mine, try again");

                s = Console.ReadLine();
                value = Convert.ToInt32(s);

            }

            Console.WriteLine("Success! Nostradamus is jealous of you!");
            Console.ReadKey();
        }
    }
}
