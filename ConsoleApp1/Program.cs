using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int GetMin(int[] numbers)
        {
            int min = numbers[0];
            int min_index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    min_index = i;
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число элементов маассива:");
            String str_count = Console.ReadLine();
            int count = int.Parse(str_count);
            int[] numbers = new int[count];
            Random rnd = new Random();
            for (int i=0; i<numbers.Length; i++)
            {
                numbers[i] = i;
                numbers[i] = count - i;
                numbers[i] = rnd.Next(5, 26);
            }
            int max1 = numbers.Max();
            int min1 = numbers.Min();
            double average = numbers.Average();
            int sum = numbers.Sum();
            Console.WriteLine("Min = {0}", GetMin(numbers));
            Console.ReadLine();


            
        }
        
    }
}
