using System;

namespace FnT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;

            int[] NS = new int[99];
            Console.Write("");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write("Input Num : ");
                NS[i] = int.Parse(Console.ReadLine());
            }
            
            int[] NS1 = new int[99];
            for (i = 1; i <= n; i++)
            {
                NS1[i] = NS[i];
            }
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - 1; j++)
                {
                    if (NS1[j] > NS1[j + 1])
                    {
                        int temp = NS1[j];
                        NS1[j] = NS1[j + 1];
                        NS1[j + 1] = temp;
                    }
                }
            }
            Console.Write("NumSort1 : ");
            for (i = 1; i <= n; i++)
            {
                Console.Write(NS1[i] + " ");
            }
            Console.WriteLine();
            

            Console.Write("NumSort2 : ");
            int[] NS2 = new int[99];
            for (i = 1; i <= n; i++)
            {
                NS2[i] = NS[i];
            }
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - 1; j++)
                {
                    if (NS2)
                    {
                        
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
