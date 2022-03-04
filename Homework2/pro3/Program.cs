using System;
using System.Collections;

namespace pro3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the prime number range from 2 to 100:");
            bool[] res = IsPrime();
            for(int i = 0; i < res.Length; ++i)
            {
                if (!res[i])
                    continue;
                Console.Write(i + " ");
            }
        }

        static private bool[] IsPrime(int maxNum = 100)
        {
            bool[] numbers = new bool[maxNum + 1];
            for(int i = 0; i < maxNum; ++i)
            {
                numbers[i] = true;
            }
            numbers[0] = false;
            numbers[1] = false;
            for(int i = 2; i*i <= maxNum; ++i)
            {
                if (!numbers[i])
                    continue;
                int div = i;
                int multi = 2;
                while(multi * div <= maxNum)
                {
                    numbers[multi * div] = false;
                    multi++;
                }
            }
            return numbers;
        }
    }
}
