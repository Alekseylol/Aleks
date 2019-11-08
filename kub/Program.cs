using System;


namespace kub
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, i = 1;
            size = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x <= size+1; x++)
            {
                if ((x == 0) || (x == size+1))
                {
                    while (i <= size)
                    {
                        if (i == size) { Console.WriteLine("_ "); }

                        else { Console.Write("_ "); }
                        i++;
                    }
                    i = 1;

                }
                else
                {
                    Console.Write("! ");
                    while (i <= size-1)
                    {
                        Console.Write("  ");
                        i++;
                          
                    }
                    i = 1;
                    Console.WriteLine("!");
                    
                }
            }

        }
    }
}



        





 