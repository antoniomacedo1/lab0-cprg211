using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0_oop2
{
    internal class Additional
    {
        static void Main(string[] args)
        {
            double lowNumber, highNumber;

            lowNumber = GetValidLowNumber();
            highNumber = GetValidHighNumber(lowNumber);

            List<double> numbers = ReadNumbersFromFile("numbers.txt");
            double sum = CalculateSum(numbers);
            Console.WriteLine($"The sum of the numbers in the file is {sum}");

            List<double> numberList = new List<double>();
            for (double i = lowNumber; i <= highNumber; i++)
            {
                numberList.Add(i);
            }

            Console.WriteLine("Numbers stored as doubles: ");
            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"Prime numbers between {lowNumber} and {highNumber}:");
            for (double i = lowNumber; i <= highNumber; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static double GetValidLowNumber()
        {
            double lowNumber;
            do
            {
                Console.WriteLine("Enter a positive low number:");
                lowNumber = Convert.ToDouble(Console.ReadLine());
            } while (lowNumber <= 0);
            return lowNumber;
        }

        static double GetValidHighNumber(double lowNumber)
        {
            double highNumber;
            do
            {
                Console.WriteLine("Enter a high number greater than the low number:");
                highNumber = Convert.ToDouble(Console.ReadLine());
            } while (highNumber <= lowNumber);
            return highNumber;
        }

        static List<double> ReadNumbersFromFile(string filePath)
        {
            List<double> numbers = new List<double>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                numbers.Add(Convert.ToDouble(line));
            }
            return numbers;
        }

        static double CalculateSum(List<double> numbers)
        {
            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static bool IsPrime(double number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (double i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
