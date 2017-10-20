using System;

namespace BullsAndCows
{
    class Program
    {

        const int NUMBER_OF_GUESS = 5;
        static void Main(string[] args)
        {
            
            WelcomeMessage();
            AskForGuess();
            
            Console.ReadLine();
        }

        static void WelcomeMessage(){
            //Welcome message
            Console.WriteLine("Welcome to the Bulls and Cows Game !");
            Console.WriteLine("You have " + NUMBER_OF_GUESS + " attempts to guess my secret word!");

        }

        static string AskForGuess(){
            //Ask for guess
            string myGuess = "";
            Console.WriteLine("Please guess: ");
            myGuess = Console.ReadLine();
            
            //Display guess
            Console.WriteLine("Your guess was :" + myGuess);
            return myGuess;
        }
        
    }
}
