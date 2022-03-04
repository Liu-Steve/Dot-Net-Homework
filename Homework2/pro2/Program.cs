using System;
using System.Collections;

namespace pro2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            int num;
            string str;
            do
            {
                Console.WriteLine("Please input the array's length:");
                str = Console.ReadLine();
            } while (!int.TryParse(str, out num) || num < 0);
            for(int i = 0; i < num; i++)
            {
                int ele;
                do
                {
                    Console.WriteLine($"Please input the {i+1} element:");
                    str = Console.ReadLine();
                } while (!int.TryParse(str, out ele));
                arr.Add(ele);
            }
            bool va = CalValue(
                arr,
                out int maxNum,
                out int minNum, 
                out float avg,
                out int sum);
            if(va)
            {
                Console.WriteLine($"maximum numbers in array is: {maxNum}");
                Console.WriteLine($"minimum numbers in array is: {minNum}");
                Console.WriteLine($"average numbers in array is: {avg}");
            }
            Console.WriteLine($"sum of numbers in array is: {sum}");
        }

        private static bool CalValue(
            ArrayList arr, 
            out int maxNum, 
            out int minNum, 
            out float avg, 
            out int sum)
        {
            if(arr.Count == 0)
            {
                maxNum = 0;
                minNum = 0;
                avg = 0;
                sum = 0;
                return false;
            }
            maxNum = (int) arr[0];
            minNum = (int) arr[0];
            sum = (int)arr[0];
            for(int i = 1; i < arr.Count; ++i)
            {
                int num = (int) arr[i];
                sum += num;
                if(maxNum < num)
                {
                    maxNum = num;
                }
                if(minNum > num)
                {
                    minNum = num;
                }
            }
            avg = (float) sum / arr.Count;
            return true;
        }
    }
}
