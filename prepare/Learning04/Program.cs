using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment as1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(as1.GetSummary());

        MathAssignment mAs1 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mAs1.GetSummary());
        Console.WriteLine(mAs1.GetHomeworkList());

        WritingAssignment wAs1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(wAs1.GetSummary());
        Console.WriteLine(wAs1.GetWritingInformation());
    }
}