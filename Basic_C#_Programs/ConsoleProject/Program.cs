using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //******Console App Assignment Part 1*******//

            //Console.WriteLine("Welcome user to the C# Console App Project.\n");
            ////A one-dimensional array of strings.
            //string[] carColors = { "Red", "Blue", "White", "Black", "Silver" };

            ////Ask the user to input some text.
            //Console.WriteLine("Please input your favorite car make.\n");
            //string carMake = Console.ReadLine();

            ////Create a loop that iterates through each string in the array and adds the user's text input to the end of each string.
            ////This step will not output anything to the console, but will update each array element by appending the user's text.
            //for (int i =0; i < carColors.Length; i++)
            //{
            //    carColors[i] = carColors[i]+" "+ carMake;
            //}
            ////Create a loop that prints off each string in the array on a separate line.
            //for (int  i =0; i< carColors.Length; i++)
            //{
            //    Console.WriteLine("\nYour choices are a: " +  carColors[i]);
            //}
            
            //Console.ReadLine();


            //******Console App Assignment Part 2*******//

            //Create and fix an infinite loop
            //The following loop continues until i < 10, which the loop conditions will never allow loop to go above the integer 10
            //The condition i < 10 will always be true

            //Negative increment infinite loop
            //for (int i = 0; i < 10; i--)
            //{
            //    Console.WriteLine("value : {0}", i);
            //}
            //Console.ReadLine();

            ////Positive increment infinite loop
            //for (int i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine("value : {0}", i);
            //}
            //Console.ReadLine();

            //Fixed loop solution
            //for (int i =0; i < 10; i++)
            //{
            //    Console.WriteLine("value : {0}", i);
            //}
            //Console.ReadLine();


            //******Console App Assignment Part 3*******//

            //Create a loop where the comparison thats used to determine whether to continue iterating the loop is a "<" operator
            //Integer array
            //int[] luckyNumbers = { 1, 3, 7, 9, 13, 15, 21, 25, 31 };

            ////Iterate through each item 
            //for (int a = 0; a < luckyNumbers.Length; a++)
            //{
            //    //if statement [i], targeting item in array
            //    if(luckyNumbers[a] < 10)
            //    {
            //        Console.WriteLine("Lucky numbers less than 10: " + luckyNumbers[a]);
            //    }
            //}
            //Console.ReadLine();

            ////Create a loop where the comparison thats used to determine whether to continue iterating the loop is a "<=" operator
            //for (int b = 0; b <= 20; b++)
            //{
            //    Console.WriteLine(b);
            //}
            //Console.ReadLine();


            //******Console App Assignment Part 4*******//

  
            ////Ask the user to input text to search for in the list.
            //Console.WriteLine("Can you guess the letters of my first name?");
            ////Created a list of strings where each item in the list is unique.
            //List<string> nameLetters = new List<string>() { "s", "e", "a", "n" };
            ////Created boolean statement to iterate through list to compare user input to actual list
            //bool checkGuess = false;
            ////Instantiate string variable to use in loop
            //string nameGuess;
            ////Create loop with while statement, stating if checkGuess is not equal to true, begin loop
            //while (checkGuess != true)
            //{
            //    //user input with instantiated string variable
            //    nameGuess = Console.ReadLine();

            //    if (nameLetters.Contains(nameGuess))
            //    {
            //        //State to user current index of choice, as well as successful guess on screen
            //        Console.WriteLine("Wow you have guessed a letter! The current index of this letter is: " + nameLetters.IndexOf(nameGuess));
            //        //Stop loop if choice was true
            //        checkGuess = true;
            //    }
            //    else
            //    {
            //        //State to user that input was not on list, and restart loop for user
            //        Console.WriteLine("Wrong guess. Try again. Input your choice please.");
            //    }

            //}
            //Console.ReadLine();


            ////******Console App Assignment Part 5*******//
            

            //Console.WriteLine("Guess a letter in the secret word, user!");
            ////Created new string list, with some strings identical
            //List<string> wordList = new List<string>() { "a", "a", "r", "d", "v", "a", "r", "k" };
            ////Like above in Assignment 4, instatiated boolean and string to use in for loop that checks users guess
            //bool letterCheck = false;
            //string userGuess;
            ////start integer at -1 to allow loop to grab 0 index
            //int count = -1;
            //    userGuess = Console.ReadLine();

            ////Create foreach loop to check user input and display message to console
            //foreach(string letter in wordList)
            //{
            //    //count++ will iterate through indexes starting at -1 to allow for index 0 to be displayed
            //    count++;
            //    //exit if statement if user chooses letter in letter in secret word
            //    if(userGuess == letter)
            //    {
            //        Console.WriteLine("You guessed a letter in the secret word! The index of that letter is: " + count + ".");
            //    }
            //}

            ////Checks and displays if user input was ! or not in wordList "list", then displays message to user
            //if(!wordList.Contains(userGuess))
            //{
            //    Console.WriteLine("Wrong choice, that letter is not in the secret word...");
            //}
            //Console.ReadLine();


            //******Console App Assignment Part 6*******//


            //Console.WriteLine("Here are the available super cars in stock. Press enter to see our choices.");
            //List<string> carName = new List<string>() { "McLaren F1", "Saleen S7", "Ferrari Enzo", "Porsche Carrera GT", "Saleen S7", "Ford GT", "Saleen S7"};
            ////Create new list to house seperate string
            //List<string> multipleCar = new List<string>();

            ////Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            //foreach (string car in carName)
            //{
            //    if (multipleCar.Contains(car))
            //    {
            //        Console.WriteLine(car + " is available with another color.");
            //    }

            //    //adds car to multipleCar list
            //    else
            //    {
            //        multipleCar.Add(car);
            //        Console.WriteLine(car);
            //    }

            //    Console.ReadLine();
            }
        }


    }
}
