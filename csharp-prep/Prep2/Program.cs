using System;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static string Sign(int gradePer)
    {
        int lastDigit;
        lastDigit = gradePer % 10;
        string sign;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        return sign;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine();

        Console.Write("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        int gradePer = int.Parse(gradePercent);
        string letter;
        Console.WriteLine();

        if (gradePer >= 90)
        {
            letter = "A";
        }
        else if (gradePer >= 80)
        {
            letter = "B";
        }
        else if (gradePer >= 70)
        {
            letter = "C";
        }
        else if (gradePer >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");
        if (gradePer >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you didn't pass this time. But, keep going strong and I'm sure you'll get it next time!");
        }
        string startSign = Sign(gradePer);
        Console.WriteLine($"Your full grade is {letter}{startSign}");


    }
}