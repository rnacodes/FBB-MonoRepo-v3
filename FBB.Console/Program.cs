using FBB.Engine.Extensions;    
using static FBB.Engine.Classes.DialogOptions;
using FBB.Engine.Classes; //Why is this redundant?
using static FBB.Engine.Classes.MagicTranslator; //Why is this redundant?

namespace FBB.ConsoleApp
{
    public class Program
    {
        static void Main()

        //Three dialogue options:
        //1. Translate user number into FizzBuzzBang language
        //2. Print number 1 through 1000 in FizzBuzz
        //3. Allow user to add their own special number and phrase
        {
            string numberInFBB;

            string userActionResponse;

            Console.WriteLine("Let's play a game! Choose from one of the following options:");

            Console.WriteLine("1. Translate a number 1 - 1000 into our special FizzBuzzBang Language! (Translate)");
            Console.WriteLine("2. Print from 1 to 1000 in FBB (Print)");
            Console.WriteLine("3. Add your own number and phrase (Add)");


            userActionResponse = Console.ReadLine() ?? string.Empty;

            ////THIS IS HOW I SET UP GUARDRAILS FOR MENU INPUT
            while (!userActionResponse.IsOptionValid())
            {
                Console.WriteLine("Please enter a valid response.");

                userActionResponse = Console.ReadLine();//.ToLower();
            }

            switch (userActionResponse)
            {
                //case ("translate"):
                case ("1"):
                    Translate();
                    break;

                //case "print":
                case ("2"):
                    Print();
                    break;

                //case "add":
                case ("3"):
                    Add();
                    break;
            };

            //Enum will be incorporated in future update
            /*
            var asdf = NewMenuOptions.Translate;

            switch (asdf)
            {
                case NewMenuOptions.Translate:
                    Console.WriteLine("Translate");
                    break;
                case NewMenuOptions.Print:
                    Console.WriteLine("Print");
                    break;
                case NewMenuOptions.Add:
                    Console.WriteLine("Add");
                    break;
            }
            */
        }
    }
}