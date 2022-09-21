using System;

namespace NumbersGame
{
    internal class Program
    {
            //Sebastian Gamboa SUT22

        static bool CheckGuess(int randomInt)
        {
            Int32.TryParse(Console.ReadLine(), out int checkGuess);
            //Checking if the input is higher or lower than the correct number
            if (checkGuess < randomInt)
            {
                Console.WriteLine("\nTyvärr du gissade för lågt!");
                return false;
            }
            else if (checkGuess > randomInt)
            {
                Console.WriteLine("\nTyvärr du gissade för högt!");
                return false;
            }
            //Correct guess going out of the loop
            else
            {
                Console.WriteLine("\nWoho! Du gjorde det!");
                return true;
            }
        }
        static void Main(string[] args)
        {
            //Here we create our variables we want static 
            bool loop = true;
            string keepGoing = "ja";

            //our loop for playing multiple times
            while (loop)
            {
                //Creating the number we want to guess
                Random randomInt = new Random();
                int guessMe = randomInt.Next(1, 21);

                //Reseting our result/tries over multiple games
                int checkGuess = 0;
                int counter = 0;

                Console.Write("Välkommen! Jag tänker på ett nummer mellan 1-20.\nKan du gissa vilket ? Du får fem försök: ");
                //loop for five tries
                while (counter < 5)
                {
                    counter++;
                    //Calling on our method and printing the result
                    if (CheckGuess(guessMe) == true)
                    {
                        checkGuess = guessMe;
                        //fiveLoop = false;
                        break;
                    }
                }
                //Checking if they won the game or not
                if (checkGuess != guessMe)
                {
                    Console.WriteLine("\nTyvärr klarade du inte att gissa nummret!");
                }
                //Asking if the user wanna play again
                Console.Write("\nVill du testa spela igen? Ja/Nej ");
                string goAgain = Console.ReadLine();

                //if they want to play again we clear the console window
                if (goAgain.ToLower() == keepGoing)
                {
                    Console.Clear();
                }
                //Otherwise we end the program
                else
                {
                    loop = false;
                }
            }
        }
    }
}
