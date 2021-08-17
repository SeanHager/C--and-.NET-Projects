using System;
using System.Collections.Generic;


namespace GuessBehindDoorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program Start

            //Declare on dimensional string array prizePool for user to choose index from
            string[] prizePool = { "A Pineapple", "A 2020 Toyota Supra, WOW!", "Some cold soup..", "A cruise to Bermuda", "1 penny. Wow really?", "A Taco" };
            Console.WriteLine("Let's play the guessing game! Input an index number, 0 through 5, to guess what you have won!\n");
            //Retrieve index from user entered input value
            int input = int.Parse(Console.ReadLine());
            //Create if statement to check if user inputs value greater than available indexes, and either closes or continues the program.
            if (input > 5)
            {
                Console.WriteLine("That's not an valid prize number. The game will now close, sorry!");
                Console.ReadLine();
                //Console force close on user
                System.Environment.Exit(0);
            }
            else
            {
                //Write out to console users selected index, with concatenated string message
                Console.WriteLine("\nYour prize is: " + prizePool[input] + " you lucky dog!");
            }
            

            //Declare one dimensional integer array luckyNum for user to choose index from
            int[] luckyNum = { 7, 13, 33, 66, 1, 22, 42 };
            Console.WriteLine("\nNow input an index number, 0 through 6, to see your lucky number for today.\n");
            //Retrieve index from user entered input value
            int luckyInput = int.Parse(Console.ReadLine());
            //Create if statement to check if user inputs value greater than available indexes, and either closes or continues the program.
            if  (luckyInput > 6)
            {
                Console.WriteLine("\nThat's not a valid choice. The game will now close, sorry!");
                Console.ReadLine();
                //Console force close on user
                System.Environment.Exit(0);
            }
            else
            {
                //Write out to console users selected index, with concatenated string message
                Console.WriteLine("\nYour lucky number is: " + luckyNum[luckyInput]);
            }

            // Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.
            List<string> mood = new List<string>{ "Happy", "Sad", "Mad", "Disgusted", "Anxious", "Blah"};
            Console.WriteLine("\nLastly, choose an index from 0 to 6 to display how you might be feeling after playing this game.\n");
            int moodInput = int.Parse(Console.ReadLine());
            //Create if statement to check if user inputs value greater than available indexes, and either closes or continues the program.
            if (moodInput > 6)
            {
                Console.WriteLine("\nThat's not a valid choice. The game will now close, sorry!");
                Console.ReadLine();
                //Console force close on user
                System.Environment.Exit(0);
            }
            else
            {
                //Write out to console users selected index, with concatenated string message
                Console.WriteLine("\nYour mood is: " + mood[moodInput]);
            }


            Console.WriteLine("\nThanks for playing. Goodbye.");
            //Pause console to read through program
            Console.ReadLine();

            //Program End

        }
    }
}
