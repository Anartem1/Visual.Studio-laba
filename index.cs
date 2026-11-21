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

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        if (N < 0)
        {
            Console.WriteLine("Error");
            return;
        }

        Console.WriteLine(Var1(N));
        Console.WriteLine(Var2(N));
        Console.WriteLine(Var3(N));
        Console.WriteLine(Var4(N));
    }
}
