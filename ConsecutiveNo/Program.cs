using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1- Write a program and ask the user to enter a few numbers separated by a hyphen.
 * Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
 * display a message: "Consecutive"; otherwise, display "Not Consecutive".
 */
namespace ConsecutiveNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter few numbers (eg 1-2-3-4)");
            var n = Console.ReadLine();


            var numbers = new List<int>();
            foreach (var number in n.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isCon = true;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isCon = false;
                    break;
                }
            }

            if (isCon)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not consecutive");
            }
        }


    }
}
