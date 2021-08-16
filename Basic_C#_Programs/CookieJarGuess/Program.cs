using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieJarGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            //Begin while loop 
            Console.WriteLine("Greetings user! Lets count out how many cookies are in a chips ahoy package!");
            //Declare integer cookies at 0 to begin while loop
            int cookies = 0;
            //Begin while loop with statement that continues printing out to to program numbers as long as cookies is less than 25, then end loop
            while (cookies < 25)
            {
                Console.WriteLine(cookies);
                //Increment cookies by 1
                cookies++;
            }

            Console.ReadLine();

            //Begin do while statement and take input from user
            Console.WriteLine("\nNow guess how many cookies Matt \"Megatoad\" Stonie ate for the world record! Hint - it is below 300!\n");
            int cookieNumber = Convert.ToInt32(Console.ReadLine());
            //Boolean statement to determine correct answer of true to be 203
            bool cookieGuess = cookieNumber == 203;

            //Begin actual do while statement 
            do
            {
                //Declare switch as cookieNumber to check against user input
                switch (cookieNumber)
                {
                    //Random case numbers that display messages if user selects certain number. Each case then breaks and re-iterates through loop again until 203 is guessed.
                    case 10:
                        Console.WriteLine("\nYou guessed 10?!.Try Again.\n");
                        Console.WriteLine("\nGuess again!\n");
                        cookieNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 15:
                        Console.WriteLine("\nYou guessed 15?!.Try Again.\n");
                        Console.WriteLine("\nGuess again!\n");
                        cookieNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 25:
                        Console.WriteLine("\nYou guessed 25?!.Try Again.\n");
                        Console.WriteLine("\nGuess again!\n");
                        cookieNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 50:
                        Console.WriteLine("\nYou guessed 50?!.Try Again.\n");
                        Console.WriteLine("\nGuess again!\n");
                        cookieNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 100:
                        Console.WriteLine("\nYou guessed 100?!.Try Again.\n");
                        Console.WriteLine("\nGuess again!\n");
                        cookieNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    //Case statement that will break loop and close program.
                    case 203:
                        Console.WriteLine("\nYou guessed 203! Correct!!! Hope he drank some milk with those cookies!\n");
                        cookieGuess = true;
                        break;
                    //Default statement created for any other number besides cases listed above.
                    default:
                        Console.WriteLine("\nWrong!\n");
                        Console.WriteLine("\nGood guess, that would be a lot of \"cookies\" for even a PC to handle! Snicker..\n");
                        Console.WriteLine("\nGuess again!\n");
                        cookieNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            //Shorthand version of 'while' section of do/while loop. Continues loop when certain loop conditions met above with !cookieGuess as loop trigger.
            while (!cookieGuess);


            Console.ReadLine(); 
        }
    }
}


