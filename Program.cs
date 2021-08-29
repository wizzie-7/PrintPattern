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
                for(int k = 1; k <= i; k++)
                {
                    Console.Write(k);
                    
                }
               
                //for (int r = i-1; r >= 1;r--)
                //{
                //    Console.Write(" ");

                //}
                //for (int c=1;c<=i-2;c++)
                //{
                //    Console.Write(c);
                //}

                Console.WriteLine();
            }
        }
    }
}
