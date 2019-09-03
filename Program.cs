/*
  Author: Tyler Powell
  Date: 9/3/2019
  Comments: Deliverable 2, Conditional Statement Assignment
            Asks the user what grade they expect to get and 
            displays a Letter grade per the Syllabus.
 */

using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user for input
            Console.WriteLine("What grade do you expect to get in ISM 4300?");

            try
            {
                // This varialbe will gather the user input
                string input = Console.ReadLine();

                /* This variable will store the number entered by the user after the 
                    input varialbe is parsed to int
                 */
                int grade = int.Parse(input);

                // Creates the letter varialbe and assigns an initial value of "A"
                string letter = "A";

                /* This if/else statement is used to conditionally test the user's input
                   and assigns the corresponding value to the 'letter' variable
                 */
                if (grade > 98)
                {
                    letter = "A+";
                }
                else if ((grade >= 92) && (grade <= 97))
                {
                    letter = "A";
                }
                else if ((grade >= 90) && (grade <= 91))
                {
                    letter = "A-";
                }
                else if ((grade >= 88) && (grade <= 89))
                {
                    letter = "B+";
                }
                else if ((grade >= 82) && (grade <= 87))
                {
                    letter = "B";
                }
                else if ((grade >= 80) && (grade <= 81))
                {
                    letter = "B-";
                }
                else if ((grade >= 78) && (grade <= 79))
                {
                    letter = "C+";
                }
                else if ((grade >= 72) && (grade <= 77))
                {
                    letter = "C";
                }
                else if ((grade >= 70) && (grade <= 71))
                {
                    letter = "C-";
                }
                else if ((grade >= 68) && (grade <= 69))
                {
                    letter = "D+";
                }
                else if ((grade >= 62) && (grade <= 67))
                {
                    letter = "D";
                }
                else if ((grade >= 60) && (grade <= 61))
                {
                    letter = "D-";
                }
                else
                {
                    letter = "F";
                }

                /* This if/else statement is used to display a grammatically correct sentence
                   using either 'a' or 'an'.
                 */
                if (grade >= 90)
                {
                    Console.WriteLine("Your grade is an " + letter + ".");
                }
                else if ((grade >= 60) && (grade <= 89))
                {
                    Console.WriteLine("Your grade is a " + letter + ".");
                }
                else
                {
                    Console.WriteLine("Your grade is an " + letter + ".");
                }

                /* This if/else statement is used to display a personalized message
                   depending on the letter grade.
                 */
                if (grade >= 90)
                {
                    Console.WriteLine("Keep up the good work!");
                }
                else if ((grade >= 80) && (grade <= 89))
                {
                    Console.WriteLine("Nice work. Try turning that B into an A.");
                }
                else if ((grade >= 70) && (grade <= 79))
                {
                    Console.WriteLine("C's get degrees but try putting in a few more study " +
                                      "hours each week to bump up your grade.");
                }
                else if ((grade >= 60) && (grade <= 69))
                {
                    Console.WriteLine("Try using the addtional resources available on Canvas." +
                                        " You can do this!");
                }
                else
                {
                    Console.WriteLine("It will take hard work to increase this grade" +
                                        " but it is not impossible. Try using the available" +
                                        " office hours and start studying more in the library." );
                }

            } // end of try
            catch
            {
                Console.WriteLine("Please use an int data type for your grade next time");
                Console.WriteLine("Press any key to exit the program and try again...");
            } // end of catch
        } // end of Main
    } // end of class
} // end of namespace
