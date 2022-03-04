using System;

namespace ShapeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Building...");
            Shape[] shapes = new Shape[10];
            for(int i = 0; i < 10; ++i)
            {
                Shape newShape;
                do
                {
                    newShape = Factory.Manufacture();
                } while (!newShape.IsValid());
                shapes[i] = newShape;
                Console.WriteLine($"{i + 1}:\t{shapes[i].Type}  \t{shapes[i].Area}");
            }
            double sum = GetShapeSum(shapes);
            Console.WriteLine($"Sum of areas in these shapes is {sum}");
        }

        public static double GetShapeSum(Shape[] shape)
        {
            double sum = 0;
            foreach(Shape sh in shape)
            {
                sum += sh.Area;
            }
            return sum;
        }
    }
}
