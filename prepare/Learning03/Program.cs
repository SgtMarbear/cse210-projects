using System;
using System.Runtime.CompilerServices;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.getFraction());
        Console.WriteLine(f1.getDecimal());
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.getFraction());
        Console.WriteLine(f2.getDecimal());
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.getFraction());
        Console.WriteLine(f3.getDecimal());
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.getFraction());
        Console.WriteLine(f4.getDecimal());

    }
}