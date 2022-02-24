using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator writen by Liu Ruiyao");
            int num1, num2;
            string op;
            while (true)
            {
                Console.WriteLine("Please input the first number:");
                string numstr1 = Console.ReadLine();
                if (int.TryParse(numstr1, out num1))
                    break;
                Console.WriteLine("Parse error!");
            }
            while (true)
            {
                Console.WriteLine("Please input the second number:");
                string numstr2 = Console.ReadLine();
                if (int.TryParse(numstr2, out num2))
                    break;
                Console.WriteLine("Parse error!");
            }
            while (true)
            {
                Console.WriteLine("Please input the operator");
                Console.WriteLine("[+,-,*,/]:");
                string opstr = Console.ReadLine();
                if (opstr == "+" || 
                    opstr == "-" ||
                    opstr == "*" ||
                    opstr == "/")
                {
                    op = opstr;
                    break;
                }
                Console.WriteLine("Parse error!");
            }
            if(op == "/" && num2 == 0)
            {
                Console.WriteLine("Number2 is 0! Couldn't calculate");
                return;
            }
            Console.WriteLine("Result:");
            switch (op)
            {
                case "+":
                    Console.WriteLine($"{num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"{num1 / num2}");
                    break;
                default:
                    break;
            }
        }
    }
}
