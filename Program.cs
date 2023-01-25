/*
 * Author: Madina Giyasova 
 * Date: 1/24/2023 
 * Description: C# Console Application  for calculating letter grades 
 * */

using System;

namespace Deliverable__2_
    {
    class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a numeric grade: ");

			try
			{
                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

            if (grade >= 90)
            {
                letter = "A";
                Console.WriteLine("Your expected letter grade for ISM 4300 is " + letter);
            }
            else if (grade >= 80 && grade < 90)
            {
                letter = "B";
                Console.WriteLine("Your expected letter grade for ISM 4300 is " + letter);
            }
            else if (grade >= 70 && grade < 80)
            {
                letter = "C";
                Console.WriteLine("Your expected letter grade for ISM 4300 is " + letter);
            }
            else if (grade >= 60 && grade < 70)
            {
                letter = "D";
                Console.WriteLine("Your expected letter grade for ISM 4300 is " + letter);
            }
            else
            {
                letter = "F";
                Console.WriteLine("Your expected letter grade for ISM 4300 is " + letter);

            }

            }
            catch
            {
                Console.WriteLine("Enter in a numeric value");
            }

			
		}

	}
    }

