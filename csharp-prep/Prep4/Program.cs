using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int finalNum = 0;
        int totalNum = 0;
        int totalCount = 0;
        List<int> numCollect = new List<int>();

        do
        {
            Console.Write("Enter Number: ");
            string number = Console.ReadLine();
            int num = int.Parse(number);
            finalNum = num;
            totalNum = totalNum + finalNum;
            totalCount += 1;
            if (finalNum != 0)
            {
                numCollect.Add(finalNum);
            }
            

        } while (finalNum != 0);

        Console.WriteLine("The sum is: " + totalNum);
        int average = totalNum / totalCount;
        Console.WriteLine("The average is: " + average);
        int largestNum = 0;

        for (int i = 0; i < numCollect.Count; i++)
        {
            if (i > largestNum)
            {
                largestNum = i;
            }
        }
        Console.WriteLine("The largest number is: " + largestNum);

    }
}