using System;
using System.Collections;

namespace pro1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string str;
            do
            {
                Console.WriteLine("Please input the number:");
                str = Console.ReadLine();
            } while (!int.TryParse(str, out num));

            var res = CalFactor(num);

            Console.WriteLine($"The faactors of {num} are:");
            foreach (int i in res)
            {
                Console.Write(i + " ");
            }
        }

        private static bool IsPrime(int num)
        {
            if (num == 2 || num == 3)
                return true;
            if (num % 6 != 1 && num % 6 != 5)
                return false;
            for(int i = 2; i*i <= num; ++i)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        private static int FindNext(int num)
        {
            num++;
            while (!IsPrime(num))
            {
                num++;
            }
            return num;
        }

        private static ArrayList CalFactor(int num)
        {
            int div = 2;
            ArrayList factor = new ArrayList();
            while(num >= div*div)
            {
                if(num % div != 0)
                {
                    div = FindNext(div);
                    continue;
                }

                factor.Add(div);
                num /= div;
            }
            factor.Add(num);
            return factor;
        }
    }
}
