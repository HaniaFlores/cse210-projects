using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Program 3: Event Planning");

        /* Lecture Event */
        Console.WriteLine("\n1st Event");
        LecturesEvent event1 = new LecturesEvent("Transforming mental health care: Lessons from the global south", "Professor Vikram Patel",
        "Vikram is committed to bring positive change in the society by amalgamating humanitarian approaches with science and innovative technological solutions.", "March 24,2023", "6:00 P.M.", new Address("University of York", "Heslington", "York", "UK"), 800);

        Console.WriteLine("\nStandard Message:");
        Console.WriteLine(event1.GetStandardDetails());
        Console.WriteLine("\nFull Detailed Message:");
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine("\nShort Message:");
        Console.WriteLine(event1.GetShortDescription());

        /* Reception Event */
        Console.WriteLine("\n2nd Event");
        ReceptionsEvent event2 = new ReceptionsEvent("Wedding Reception", "You are cordially invited to celebrate the wedding of Sara Johnson & Thomas Simmons", "June 2,2023", "4:00 P.M.", new Address("55 Watt Ave", "Sacramento", "CA", "USA"), "rsvp@keshevents.com ");

        Console.WriteLine("\nStandard Message:");
        Console.WriteLine(event2.GetStandardDetails());
        Console.WriteLine("\nFull Detailed Message:");
        Console.WriteLine(event2.GetFullDetails());
        Console.WriteLine("\nShort Message:");
        Console.WriteLine(event2.GetShortDescription());

        /* Outdoor Event */
        Console.WriteLine("\n3rd Event");
        OutdoorEvent event3 = new OutdoorEvent("Coachella 2023", "Miraculous outfits, 250 thousand fans, 167 artists, and 3 days of pure music joy.","April 14 - 16, 2023", "12:00 P.M.", new Address("Empire Polo Field", "Indio", "CA", "USA"), "Comfortable temperatures with low of 55°F and and high up to 75°F.");

        Console.WriteLine("\nStandard Message:");
        Console.WriteLine(event3.GetStandardDetails());
        Console.WriteLine("\nFull Detailed Message:");
        Console.WriteLine(event3.GetFullDetails());
        Console.WriteLine("\nShort Message:");
        Console.WriteLine(event3.GetShortDescription());
    }
}