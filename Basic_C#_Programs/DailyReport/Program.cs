using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console App Intro Statements
            Console.WriteLine("The Tech Academy\n");
            Console.WriteLine("Student Daily Report\n");

            //Prompt user for input, assigned string "name" to Console.Readline for user input
            Console.WriteLine("\nWhat is your name?\n");
            string name = Console.ReadLine();

            //Prompt user for input, assigned string "courseName" to Console.Readline for user input
            Console.WriteLine("\nWhat course are you on?\n");
            string courseName = Console.ReadLine();

            //Prompt user for integer input, casting integer to Readline string for user input
            Console.WriteLine("\nWhat page number?\n");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            //Prompt user for boolean input, converting string to boolean for user input
            Console.WriteLine("\nDo you need help with anything? Please answer “true\" or \"false\"! \n");
            bool courseHelp = Convert.ToBoolean(Console.ReadLine());

            //Prompt user for input, assigned string "courseExperience" to Console.Readline for user input
            Console.WriteLine("\nWere there any positive experiences you’d like to share? Please give specifics.\n");
            string courseExperience = Console.ReadLine();

            //Prompt user for input, assigned string "courseFeedback" to Console.Readline for user input
            Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific.\n");
            string courseFeedback = Console.ReadLine();

            //Prompt user for integer input, casting integer to Readline string for user input
            Console.WriteLine("\nHow many hours did you study today?\n");
            int studyTime = Convert.ToInt32(Console.ReadLine());

            //Program end with Console.Writeline command and Console.Readline command to keep program open at end.
            Console.WriteLine("\n\"Thank you for your answers. An Instructor will respond to this shortly. Have a great day!\" This is the end of the program.");

            Console.ReadLine();
        }
    }
}
