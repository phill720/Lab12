using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Library
{
    public class Class1
    {
        public static int PlayJimmy(string choice)
        {
            if (choice == "paper")
            {
                Console.WriteLine("John:\tRock");
                Console.WriteLine("You beat Jimmy");
                return +1;
            }
            else if (choice == "scissors")
            {
                Console.WriteLine("John:\tRock");
                Console.WriteLine("You lost to Jimmy");
                return +0;
            }
            else
            {
                Console.WriteLine("John:\tRock");
                Console.WriteLine("Draw!");
                return +0;
            }
        }

        List<string> RPS = new List<string> { "Rock", "Paper", "Scissors" };

        public static int PlayJohns(string choice)
        {
            List<string> RPS = new List<string> { "Rock", "Paper", "Scissors" };
            Random num = new Random (3);
            int i = num.Next(3);
            string JohnChoice = RPS[i];
            Console.WriteLine("John:\t" + JohnChoice);
            if (JohnChoice.ToLower() == "Rock" && choice == "Rock")
            {
                Console.WriteLine("John:\tRock");
                Console.WriteLine("You lost to Jimmy");
                return + 0;
            }
            else if (JohnChoice.ToLower() == "Rock" && choice == "Paper")
            {
                Console.WriteLine("John:\tRock");
                Console.WriteLine("You lost to Jimmy");
                return +0;
            }
            else if (JohnChoice.ToLower() == "Rock" && choice == "Scissors")
            {
                Console.WriteLine("John:\tRock");
                Console.WriteLine("You lost to Jimmy");
                return +0;
            }
            else if (JohnChoice.ToLower() == "Paper" && choice == "Rock")
            {
                Console.WriteLine("John:\tRock");
                Console.WriteLine("You lost to Jimmy");
                return +0;
            }
            else if (JohnChoice.ToLower() == "Paper" && choice == "Paper")
            {
                Console.WriteLine("John:\tRock");
                Console.WriteLine("You lost to Jimmy");
                return +0;
            }
            else if (JohnChoice.ToLower() == "Paper" && choice == "Scissor")
            {
                Console.WriteLine("John:\tRock");
                Console.WriteLine("You lost to Jimmy");
                return +0;
            }
            else if (JohnChoice.ToLower() == "Scissor" && choice == "Rock")
            {
                Console.WriteLine("John:\tRock");
                Console.WriteLine("You lost to Jimmy");
                return +0;
            }
            else if (JohnChoice.ToLower() == "Scissor" && choice == "Paper")
            {
                Console.WriteLine("John:\tRock");
                Console.WriteLine("You lost to Jimmy");
                return +0;
            }
            else 
            {
                Console.WriteLine("John:\tRock");
                Console.WriteLine("You lost to Jimmy");
                return +0;
            }
        }
    }
}
