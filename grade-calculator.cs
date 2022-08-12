using System;

namespace CSD228.MidTerm

{

    class Program

    {

        private static string[] letterGrades;

        static void Main(string[] args)

        {

            InitLetterGrades();

            bool done = false;

            while (!done)

            {

                Console.Write("Please enter a numeric grade (0-100): ");

                string s = Console.ReadLine();

                double g = 0;

                try

                {

                    g = double.Parse(s);

                }

                catch (FormatException)

                {

                    Console.WriteLine("That doesn't look like a number.");

                    continue;

                }

                catch (OverflowException)

                {

                    Console.WriteLine("The number is too big.");

                }

                if (g < 0.0 || g > 100.0)

                {

                    Console.WriteLine("Please enter a number between 0 and 100.");

                }

                Console.WriteLine($"The corresponding letter grade is: {LetterGrade(g)}");

            }

        }

        private static void InitLetterGrades()

        {

            letterGrades = new string[100];

            for (int i = 0; i < 100; i++)

            {

                if (i < 60)

                    letterGrades[i] = "F";

                else if (i < 70)

                    letterGrades[i] = "D";

                else if (i < 80)

                    letterGrades[i] = "C";

                else if (i < 90)

                    letterGrades[i] = "B";

                else if (i < 100)

                    letterGrades[i] = "A";

            }

        }

        private static string LetterGrade(double grade)

        {

            if (grade < 0.0 || grade > 100.0)

                return "Invalid grade specified";

            return letterGrades[(int)grade - 1];

        }

    }

}