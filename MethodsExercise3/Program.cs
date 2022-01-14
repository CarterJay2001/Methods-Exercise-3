using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            ThousandCount();
            ThreeCount();
            EqualCheck();
            EvenOrOdd();
            PosOrNeg();
            Vote();
            TenRange();
            MultTables();

            Console.WriteLine("The End!");
        }

        public static void Enter()
        {
            Console.WriteLine("(press Enter to continue)");
            Console.ReadLine();
        }

        public static void ThousandCount()
        {
            Console.WriteLine("Welcome: First things first lets make sure we remember" +
                " how to count!\n\nLet's go from 1000 to -1000:");
            Enter();

            for (int i = 1000; i > -1001; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nDid I do it? (yes or no)");
            string work = Console.ReadLine();

            switch (work.ToLower())
            {
                case "yes":
                case "y":
                case "ye":
                    Console.WriteLine("\nGreat that worked!");
                    break;
                case "no":
                case "n":
                    Console.WriteLine("\nAre you sure? I think you're lying. No matter on to the next");
                    break;
                default:
                    Console.WriteLine("\nI don't understand? Going to assume I did though!");
                    break;
            }
        }

        public static void ThreeCount()
        {
            Console.WriteLine("\nNow let's do 3 to 99 but by 3s:");

            Enter();

            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }
            Enter();
        }

        public static void EqualCheck()
        {
            Console.WriteLine("\nI was a little worried that one might fail if I'm being honest\n" +
                "For my next trick I will need two numbers from you\n" +
                "I will then tell you if your numbers are equal or not\n" +
                "\nYour first number please:");
            bool success = false;
            int equalNum1 = 0;
            while (!success)
            {
                success = int.TryParse(Console.ReadLine(), out equalNum1);
                if (!success)
                {
                    Console.WriteLine("\nThat's not a number! Try again!");
                }
            }
            success = false;

            Console.WriteLine("\nPerfect! and the next one:");


            int equalNum2 = 0;
            while (!success)
            {
                success = int.TryParse(Console.ReadLine(), out equalNum2);
                if (!success)
                {
                    Console.WriteLine("\nThat's not a number! Try again!");
                }
            }
            Console.WriteLine($"\nI've Done it! {equalNum1} and {equalNum2} are, drumroll please...");
            Enter();
            Console.WriteLine((equalNum1 == equalNum2) ? "Equal!\n" : "Not Equal!\n");
            Enter();
        }

        public static void EvenOrOdd()
        {
            Console.WriteLine("Next up you will give me a number and I will tell you whether it's even or odd." +
                "\n\nYour Number Please:");

            bool success = false;
            int eoNum = 0;
            while (!success)
            {
                success = int.TryParse(Console.ReadLine(), out eoNum);
                if (!success)
                {
                    Console.WriteLine("\nThat's not a number! Try again!");
                }
            }
            Console.WriteLine($"\nI've Done it! {eoNum} is, drumroll please...");
            Enter();
            Console.WriteLine((eoNum % 2 == 0) ? "Even!\n" : "Odd!\n");
            Enter();
        }

        public static void PosOrNeg()
        {
            Console.WriteLine("Next up you will give me a number and I will tell you whether it's positive or negative." +
                "\n\nYour Number Please:");

            bool success = false;
            int pnNum = 0;
            while (!success)
            {
                success = int.TryParse(Console.ReadLine(), out pnNum);
                if (!success)
                {
                    Console.WriteLine("\nThat's not a number! Try again!");
                }
            }
            Console.WriteLine($"\nI've Done it! {pnNum} is, drumroll please...");
            Enter();
            Console.WriteLine((pnNum < 0) ? "Negative!\n" : "Positive!\n");
            Enter();
        }

        public static void Vote()
        {
            Console.WriteLine("Next up tell me how old you are. I bet I can tell if you can vote or not." +
                "\n\nYour Age Please:");

            bool success = false;
            int voteAge = 0;
            while (!success)
            {
                success = int.TryParse(Console.ReadLine(), out voteAge);
                if (!success)
                {
                    Console.WriteLine("\nThat's not a number! Try again!");
                }
            }
            Console.WriteLine($"\nSo you are {voteAge} years old, that means you...");
            Enter();
            Console.WriteLine((voteAge < 18) ? "Can't Vote!\n" : "Can Vote!\n");
            Enter();
        }

        public static void TenRange()
        {
            Console.WriteLine("Next up give me a number and I'll tell you if it's between -10 and 10" +
                "\n\nYour Number Please:");

            bool success = false;
            int tNum = 0;
            while (!success)
            {
                success = int.TryParse(Console.ReadLine(), out tNum);
                if (!success)
                {
                    Console.WriteLine("\nThat's not a number! Try again!");
                }
            }
            Console.WriteLine($"\nI've Done it! {tNum} is, drumroll please...");
            Enter();
            Console.WriteLine((tNum <= 10 && tNum >= -10 ) ? "In the range!\n" : "Not in the range!\n");
            Enter();
        }

        public static void MultTables ()
        {
            Console.WriteLine("Next up give me a number between 1 and 12 and I'll give you it's multiplication table!" +
                "\n\nYour Number Please:");

            bool success = false;
            bool check = false;
            int multNum = 0;
            while (!success || !check)
            {
                success = int.TryParse(Console.ReadLine(), out multNum);
                if (!success)
                {
                    Console.WriteLine("\nThat's not a number! Try again!");
                }

                if (multNum < 1 || multNum > 12)
                {
                    Console.WriteLine("\nThat's not between 1 and 12! Try again!");
                }
                else
                {
                    check = true;
                }
            }

            Console.WriteLine($"\nI've Done it! The multiplication table for {multNum} is, drumroll please...");
            Enter();

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{multNum} * {i} = {multNum * i}");
            }
        }
    }
}
