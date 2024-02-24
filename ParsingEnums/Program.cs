using System;
using static ParsingEnums.DaysOfWeek;
//PARSING ENUMS ASSIGNMENT

//NOTE: This assignment is a challenge. To complete this challenge, you will need to do some online research on how to parse enums.


//Perform these actions and create a console app that includes the following:


//Create an enum for the days of the week.

//Prompt the user to enter the current day of the week.

//Assign the value to a variable of that enum data type you just created.

//Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.

//Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
namespace ParsingEnums
{
    internal class Program
    {
        public static void Main(string[] args)
        {


            try
            {
                Console.Write("Enter day of week here: ");
                string inputDay = Console.ReadLine();
                string test = inputDay.ToUpper(); //converts the user input to uppercase letters. this will "equalize" anything to output all uppercase. 

                ListOfDays weekDay;

                if (Enum.TryParse<ListOfDays>(test, true, out weekDay))// this line takesj string input and parses the enumerator object to integer. It outputs a variable readable by weekday (instead of by a number). 
                {
                    Console.WriteLine("You entered: " + test );
                }

                else
                {
                    throw new OverflowException();
                }


            }   

            catch (OverflowException)
            {
                Console.WriteLine("Please try again; enter a day of the week here: "); //here there is a 2nd chance to put in a weekday if the first one did not go through.

            }
                
            

            Console.ReadLine();
            return;


        }

    }

    }



