using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Method_Library;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name:\t");
            string UserName = Console.ReadLine();
            string opponent = "";
            int wins = 0;
            Console.Write("Would you like to play against Jimmy or Johns?:\t");
            try
            {
                opponent = Console.ReadLine();

                if (opponent.ToLower() == "jimmy" || opponent.ToLower() == "johns")
                {
                    Console.WriteLine("Select Rock, Paper, or Scissors:\t");
                Weapon:
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "rock" || choice == "paper" || choice == "scissors")
                    {
                        if (opponent.ToLower() == "jimmy")
                        {
                            wins += Class1.PlayJimmy(choice);
                            Console.WriteLine(wins);
                        }
                        else
                        {

                            wins += Class1.PlayJohns(choice);
                            Console.WriteLine(wins);
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"You cannot use {choice} in Roshambo. Choose again");
                        goto Weapon;
                    }
                }

                else
                {
                    throw new ArgumentException($"You are not able to play against {opponent}.");
                }
            }
            catch
            {
                Console.WriteLine($"You are not able to play against {opponent}.");
                //throw new ArgumentException($"You are not able to play against {opponent}."); 
            }
        }
    }
    
}
