using System;
namespace ConsoleApp1
{
    public class Program
    {
        static public int Example(int a)
        {
            int n = a;
            Console.Write(n % 10);
            while ((n /= 10) != 0)
            {
                Console.Write(n % 10);
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            string S1 = Console.ReadLine();
            int a = int.Parse(S1);
            Example(a);
            Console.ReadLine();
        }
    }
}
