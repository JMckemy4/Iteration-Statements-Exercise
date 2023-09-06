using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Programs
    {
        static void Main(string[] args)
        {

            //Call the methods to test them in the Main method below
            PrintNumbers();
            PrintBy3();
            EvenOrOdd(6);
            PositiveOrNegative(-3);
            CheckVotingAge();

        }
        public static void PrintNumbers()
        {
            //LukeWarm Section: Create methods below
            //Write a method that will print to the console all numbers 1000 through - 1000
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintBy3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }



        //for (int i = 3; i <=999; i += 3)
        //{
        //    Console.WriteLine(i);
        public static void EvenOrOdd(int num)
        {
            //Write a method to accept two integers as parameterss and check whether they are equal or not
            Console.WriteLine("pick a number");

            //Write a method to check whether a given number is even or odd
            int evenOdds = int.Parse(Console.ReadLine());
            int resp = evenOdds % 2;

            //Write a method to check whether a given number is positive or negative
            if (resp == 0)
            {
                Console.WriteLine("is this even");
            }
            else
            {
                Console.WriteLine("this is odd");
            }
        }


        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void PositiveOrNegative(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("This number is negative");
            }
            else
            {
                Console.WriteLine("This number is positive");
            }
        }


        //Hint: Use Parse or the safer TryParse() for an extra challenge
        public static void CheckVotingAge()
        {
            Console.WriteLine("What is your age:");
            bool validNumber = int.TryParse(Console.ReadLine(), out int userAge);
            while (!validNumber)
            {
                Console.WriteLine("Sorry, that is invalid input, Please enter your age:");
                validNumber = int.TryParse(Console.ReadLine(), out userAge);
            }
            if (userAge < 18)
            {
                Console.WriteLine("Sorry, you cant vote");
            }
            else
            {
                Console.WriteLine("yes you can vote");
            }
            

              


                
            }
        }

        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
     
    }


 



          
    



