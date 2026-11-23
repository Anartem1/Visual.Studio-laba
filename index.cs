using System;
using System.Text;

internal class Program
{
    static string Var1(int A)
    {
        string result1 = "";

        for (int i = 1; i <= A; i++)
        {
            if (i > 1) result1 += " ";
            result1 += i;
        }

        return result1;
    }

    static string Var2(int A)
    {
        string result2 = "";

        for (int i = A; i >= 1; i--)
        {
            if (i < A) result2 = " " + result2;
            result2 = i + result2;
        }

        return result2;
    }

    static string Var3(int A)
    {
        StringBuilder sb3 = new StringBuilder();
        for (int i = 1; i <= A; i++)
        {
            if (i > 1) sb3.Append(" ");
            sb3.Append(i);
        }
        string result3 = sb3.ToString();
        return result3;
    }

    static string Var4(int A)
    {
        StringBuilder sb4 = new StringBuilder();
        for (int i = A; i >= 1; i--)
        {
            if (i < A) sb4.Insert(0, " ");
            sb4.Insert(0, i);
        }
        string result4 = sb4.ToString();
        return result4;
    }

    static void Main()
    {
        Console.WriteLine("Enter a number C (1-4):");

        int C = int.Parse(Console.ReadLine());

        if (C < 1 || C > 4)
        {
            Console.WriteLine("Error");
            return;
        }

        Console.WriteLine("Enter a positive integer N:");

        int N = int.Parse(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("Error");
            return;
        }

        switch (C)
        {
            case 1:
                Console.WriteLine(Var1(N));
                return;
            case 2:
                Console.WriteLine(Var2(N));
                return;
            case 3:
                Console.WriteLine(Var3(N));
                return;
            case 4:
                Console.WriteLine(Var4(N));
                return;
            default:
                Console.WriteLine("Error");
                return;
        }           
    }
}