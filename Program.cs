using System;

namespace KUBS
{
    class Program
    {
 

        static void Main(string[] args)
        {
            int[,] mas = NewMethod();
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            for (int i = 0; i < rows; i++) ;

        }

        private static int[,] NewMethod()
        {
            return { { 1, V, 3 }, { v, 5, 6 }, { 7, 8, 9 }, { 00, 00, 00 }, { 00, 77, 77 } };
        }
    }
}
