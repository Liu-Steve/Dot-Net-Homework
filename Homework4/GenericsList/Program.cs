using System;

namespace GenericsList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Testing Generics Lists-----");
            GenericsList<int> list = new();
            for(int i = 10; i > 0; --i)
            {
                list.Insert(i);
            }

            Console.WriteLine("-----Print element in Lists-----");
            GenericsList<int>.Foreach(list, d => Console.WriteLine($"{d}"));

            Console.WriteLine("-----Print the max element-----");
            int maxEle = list.GetFirst();
            GenericsList<int>.Foreach(list, d => maxEle = Math.Max(maxEle, d));
            Console.WriteLine($"Max value in list is {maxEle}");

            Console.WriteLine("-----Print the min element-----");
            int minEle = list.GetFirst();
            GenericsList<int>.Foreach(list, d => minEle = Math.Min(minEle, d));
            Console.WriteLine($"Max value in list is {minEle}");

            Console.WriteLine("-----Print the sum-----");
            int sum = 0;
            GenericsList<int>.Foreach(list, d => sum += d);
            Console.WriteLine($"Sum in list is {sum}");
        }
    }
}
