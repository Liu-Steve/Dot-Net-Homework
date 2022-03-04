using System;

namespace pro4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4] {
                { 1, 2, 3, 4 },
                { 5, 1, 2, 3 },
                { 9, 5, 1, 2 }
            };
            //Console.WriteLine("the matrix:");
            if(isValid(arr))
            {
                Console.WriteLine("the matrix is valid");
            }
            else
            {
                Console.WriteLine("the matrix is not valid");
            }
        }

        static private bool isValid(int[,] arr)
        {
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    int num = arr[i, j];
                    if (i > 0 && 
                        j > 0 && 
                        arr[i - 1, j - 1] != num)
                        return false;
                    if (i < row - 1 && 
                        j < col - 1 && 
                        arr[i + 1, j + 1] != num)
                        return false;
                }
            }
            return true;
        }
    }
}
