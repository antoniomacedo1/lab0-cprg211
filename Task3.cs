/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0_oop2
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            int lowNumber, highNumber;

            do
            {
                Console.WriteLine("Enter a positive low number");
                lowNumber = Convert.ToInt32(Console.ReadLine());
            } while (lowNumber <= 0);

            do
            {
                Console.WriteLine("Enter a high number, greater than the low number that was typed");
                highNumber = Convert.ToInt32(Console.ReadLine());
            } while (highNumber <= lowNumber);

            int[] numbers = new int[highNumber];

            for (int i = lowNumber; i <= numbers.Length; i++)
            {
                numbers[i] = lowNumber + 1;
            }

            using (StreamWriter sw = new StreamWriter("numbers.txt"))
            {
                foreach (int number in numbers.Reverse())
                {
                    sw.WriteLine(number);
                }
            }
        }
    }
}
*/