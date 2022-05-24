// See https://aka.ms/new-console-template for more information
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine(" enter 1 for + 2 for  - 3 for * 4 for %");
        int oper = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter 1st number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter 2nd number");
        int b = Convert.ToInt32(Console.ReadLine());

        if (oper == 1)
        {
            Console.WriteLine("ans is " + (a + b));
        }
        if (oper == 2)
        {
            Console.WriteLine("ans is " + (a - b));
        }
        if (oper == 3)
        {
            Console.WriteLine("ans is " + (a * b));
        }
        if (oper == 4)
        {
            Console.WriteLine("ans is " + (a / b));
        }

    }
}