using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citp180_week002
{
    class Program
    {
        static void Main(string[] args)
        {
            // CITP180 - Week 2 
            problem001();
            problem002();
            problem003();
            problem006();
            problem007();
            problem010();
        }

        private static void problem010()
        {
            // Problem 10
            Console.WriteLine("\nProblem 10\n");
            double msmPrice = 2.09; // $2.09 per 100 grams  
            double lbs;
            double grams;
            double price;

            Console.WriteLine("Pounds of MSM: ");
            lbs = Convert.ToDouble(Console.ReadLine());

            grams = lbs * 453.592;

            price = (grams / 100) * msmPrice;

            Console.WriteLine("Total Grams: " + grams + "\tPrice: " + price.ToString("C"));
        }

        private static void problem007()
        {
            // Problem 7
            Console.WriteLine("\nProblem 7\n");
            const int change = 94;
            const int quarter = 25;
            const int dime = 10;
            const int nickel = 5;
            const int penny = 1;

            int leftover;
            int numOfQuarters;
            int numOfDimes;
            int numOfNickels;
            int numOfPennies;

            numOfQuarters = change / quarter;
            leftover = change % quarter;

            numOfDimes = leftover / dime;
            leftover = leftover % dime;

            numOfNickels = leftover / nickel;
            leftover = leftover % nickel;

            numOfPennies = leftover / penny;
            leftover = leftover % penny;

            Console.WriteLine("Quarters: " + numOfQuarters +
                "\nDimes: " + numOfDimes + "\nNickels: " + numOfNickels +
                "\nPennies: " + numOfPennies);
        }

        private static void problem006()
        {
            //// Problem 6
            Console.WriteLine("\nProblem 6\n");
            int[] scores = new int[6];
            int i;
            int input;
            int sum = 0;

            for (i = 1; i < 6; i++)
            {
                Console.WriteLine("Score " + i + ": ");
                input = Convert.ToInt32(Console.ReadLine());
                scores[i] = input;
                sum += input;
                Console.WriteLine("Quiz " + i + ": " + scores[i] + "\t Sum of Scores: " + sum);
            }
        }

        private static void problem003()
        {
            // Problem 3
            Console.WriteLine("\nProblem 3\n");
            int celsius = 32;
            double fahrenheit;

            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Celius = 32\tFahrenheit = " + fahrenheit);
        }

        private static void problem002()
        {
            // Problem 2
            Console.WriteLine("\nProblem 2\n");
            int miles = 10;
            double kilometers;

            kilometers = miles * 1.60934;

            Console.WriteLine("Miles = 10\tKilometers = " + kilometers);
        }

        private static void problem001()
        {
            // Problem 1
            Console.WriteLine("\nProblem 1\n");
            double feet;
            double inches;
            double miles = 4.5;

            Console.WriteLine("Miles = 4.5");

            feet = miles * 5280;
            Console.WriteLine("Feet = " + feet);

            inches = feet * 12;
            Console.WriteLine("Inches = " + inches);
        }
    }
}