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

                /* This IF/ELSE IF/ELSE statement is used to conditionally test the user's input
                   and assigns the corresponding value to the 'letter' variable
                 */
                if (grade >= 98)
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
                else if ((grade >= 0) && (grade <= 59))
                {
                    letter = "F";
                }
                else
                {
                    Console.WriteLine("Please input a positive value.");
                }

                /* This IF/ELSE IF/ELSE statement is used to display a grammatically correct sentence
                   using either 'a' or 'an'. There are also switch statements embedded within
                   the 'else if' section.
                 */
                if (grade > 100)
                {
                    Console.WriteLine("Your grade is an " + letter + ".");
                    Console.WriteLine("Wow extra credit! Fantastic job!");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade >= 90) && (grade <= 100))
                {
                    Console.WriteLine("Your grade is an " + letter + ".");
                    Console.WriteLine("Keep up the good work!");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grade >= 60) && (grade <= 89))
                {
                    Console.WriteLine("Your grade is a " + letter + ".");
                    switch (letter)
                    {
                        case "B+":
                        case "B":
                        case "B-":
                            Console.WriteLine("Nice work. Try turning that B into an A.");
                            Console.WriteLine("Press any key to exit the program...");
                            Console.ReadKey(true);
                            break;
                        case "C+":
                        case "C":
                        case "C-":
                            Console.WriteLine("C's get degrees but try putting in a few more " +
                                              "study hours each week to bump up your grade.");
                            Console.WriteLine("Press any key to exit the program...");
                            Console.ReadKey(true);
                            break;
                        case "D+":
                        case "D":
                        case "D-":
                            Console.WriteLine("Try using the additional resources available " +
                                                "on Canvas. You can do this!");
                            Console.WriteLine("Press any key to exit the program...");
                            Console.ReadKey(true);
                            break;
                    }
                }
                else if ((grade >= 0) && (grade <= 59))
                {
                    Console.WriteLine("Your grade is an " + letter + ".");
                    Console.WriteLine("It will take hard work to increase this grade" +
                                        " but it is not impossible. Try using the available" +
                                        " office hours and start studying more in the library.");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Negative numbers are not allowed.");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }

            } // end of try
            catch
            {
                Console.WriteLine("Please use an int data type for your grade next time.");
                Console.WriteLine("Press any key to exit the program and try again...");
            } // end of catch
        } // end of Main
    } // end of class
} // end of namespace
