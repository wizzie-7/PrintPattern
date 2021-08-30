using System;

namespace PrintPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter Number :");
            n = Convert.ToInt32(Console.ReadLine());
            Pattern p = new Pattern();
            p.PrintPatern(n);
        }
    }
    public class Pattern
    {
        public void PrintPatern(int n)
        {
            //int m = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k);

                }
                for (int m = i - 1; m >= 1; m--)
                {
                    Console.Write(m);
                }
                

                Console.WriteLine();
            }
            for (int i = n-1; i >= 1; i--)
            {
                
                for (int k = n-i; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int m = i-1; m >=1; m--)
                {
                    Console.Write(m);
                }
                Console.WriteLine();
            }
        }
    }
}
