using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Public Speaking", "Learn public speaking.", 
            new DateTime(2024, 7, 25), new TimeSpan(14, 0, 0), 
            new Address("123 Main St", "Anytown", "CA", "12345"), 
            "John Doe", 50);

        Reception reception = new Reception("Summer Social Mixer", "Join us for an evening of networking and fun.", 
            new DateTime(2024, 8, 10), new TimeSpan(18, 30, 0), 
            new Address("456 Elm St", "Sometown", "NY", "67890"), 
            "rsvp@example.com");

        OutdoorGathering gathering = new OutdoorGathering("Family Picnic", "Bring your family and enjoy a day outdoors.", 
            new DateTime(2024, 9, 15), new TimeSpan(11, 0, 0), 
            new Address("789 Oak Ave", "Dallas", "TX", "54321"), 
            "Sunny with a chance of clouds");

        Console.WriteLine("--- Standard Details ---");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("--- Full Details ---");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("--- Short Description ---");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("--- Standard Details ---");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("--- Full Details ---");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("--- Short Description ---");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("--- Standard Details ---");
        Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("--- Full Details ---");
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("--- Short Description ---");
        Console.WriteLine(gathering.GetShortDescription());
    }
}