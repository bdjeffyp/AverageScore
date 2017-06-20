using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageScore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            bool flag = true;
            float totalScore = 0.0f;
            int numScores = 0;
            string result = "";
            float testValue = 0.0f;
            char letterGrade = 'A';
            float averageScore = 0.0f;

            // Title and intro
            Console.WriteLine("Average Score Calculator");
            Console.WriteLine("By Jeff Peterson");

            Console.WriteLine("\nInput all of the scores to average");
            Console.WriteLine("Once all scores are entered, type 'quit'");
            Console.WriteLine("The scores will be averaged and a letter grade assigned\n");

            // Enter the game loop!
            while (flag)
            {
                // Iterate the number of scores.
                numScores++;

                // Get the input from the user.
                Console.Write("Grade {0,2}: ", numScores);
                result = Console.ReadLine();

                // Verify that the result is valid data.
                if (float.TryParse(result, out testValue) == false)
                {
                    // If the user is done, break out of here!
                    if (result == "quit")
                    {
                        break;
                    }

                    // If it isn't "quit", give notice and restart.
                    Console.WriteLine("That was not a valid input.  Try again.");
                    continue;
                }

                // Okay, so we have a number, but is it valid?
                if (testValue < 0.0f && testValue > 100.0f)
                {
                    // Not valid!  Try again!
                    Console.WriteLine("That was not between 0.00 - 100.00.  Try again.");
                    continue;
                }

                // We actually have a valid number.  Save it and repeat.
                totalScore += testValue;
            }

            // All done.  Now to show the average score and letter grade.
            Console.WriteLine("\nAfter collecting and analyzing the data,");
            averageScore = totalScore / numScores;
            Console.WriteLine("This student has an average of {0}", averageScore);
            if (averageScore >= 90.0f && averageScore <= 100.0f)
            {
                letterGrade = 'A';
            }
            else if (averageScore >= 80.0f && averageScore < 90.0f)
            {
                letterGrade = 'B';
            }
            else if (averageScore >= 70.0f && averageScore < 80.0f)
            {
                letterGrade = 'C';
            }
            else if (averageScore >= 60.0f && averageScore < 70.0f)
            {
                letterGrade = 'D';
            }
            else        // averageScore < 60.0f
            {
                letterGrade = 'F';
            }
            Console.WriteLine("and a letter grade of {0}", letterGrade);
        }
    }
}
