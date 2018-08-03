using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public enum Event
    {
        Skate = 1, Snowboarding = 2, Skydiving = 3, Concert = 4, Misc = 5
    }

    public class Program

    {

        public static void Main(string[] args)
        {
            Outings one = new Outings((Event)1, 5, "02/18/2018", 10, 50);
            Outings two = new Outings((Event)2, 10, "03/15/2018", 15, 150);
            Outings three = new Outings((Event)3, 5, "04/25/2018", 20, 100);
            Outings four = new Outings((Event)4, 10, "05/22/2018", 50, 500);
            Outings five = new Outings((Event)1, 10, "06/08/2018", 20, 200);

            OutingRepository _outsRepo = new OutingRepository();

            _outsRepo.AddOutingToList(one);
            _outsRepo.AddOutingToList(two);
            _outsRepo.AddOutingToList(three);
            _outsRepo.AddOutingToList(four);
            _outsRepo.AddOutingToList(five);

            while (true)
            {
                Console.WriteLine("Hi, manager. Please select what you would like to do.\n" +
               "Select 1 to Display a list of all outings.\n" +
               "Select 2 to Add individual outings to a list.\n" +
               "Select 3 to calculate cost of all outings.\n" +
               "Select 4 to calculate cost of outings by type.");
                string theAnswer = Console.ReadLine();

                if (theAnswer == "1")
                {

                    List<Outings> groupout = _outsRepo.GetList();

                    Console.WriteLine("Press enter to view the menu list:");

                    Console.ReadLine();

                    foreach (Outings outing in groupout)
                    {
                        Console.WriteLine($"Event Type: {outing.Type}\n" +
                            $"Number of People: {outing.People}\n" +
                            $"Date of Outing: {outing.Date}\n" +
                            $"Cost Per Person: {outing.Person}\n" +
                            $"Total Cost: {outing.Total}\n");
                    }
                }

                if (theAnswer == "2")
                {
                    Console.WriteLine("Enter the type of event:");
                    int usetype = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number of people that went on the outing:");
                    int usepeople = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the date of the outing:");
                    string dateout = Console.ReadLine();
                    Console.WriteLine("Enter the cost per person:");
                    double personcost = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the total cost of this outing");
                    int totalcost = int.Parse(Console.ReadLine());

                    Event eventin = (Event)usetype;

                    Outings usercake = new Outings(eventin, usepeople, dateout, personcost, totalcost);

                    _outsRepo.AddOutingToList(usercake);
                }

                if (theAnswer == "3")
                {
                    Console.WriteLine($"The total for all outings is: {_outsRepo.TotalAllOutings()}");
                    Console.ReadLine();
                }

                if (theAnswer == "4")
                {
                    while (true)
                    {
                        Console.WriteLine("What type of event would you like to see the totals for?\n" +
                             "Press 1 for Golf.\n" +
                             "Press 2 for Bowling.\n" +
                             "Press 3 for Amusement Park.\n" +
                             "Press 4 for Concert.\n" +
                             "Press 5 for Undefined Event. ");
                        string userinput = Console.ReadLine();

                        if (userinput == "1")
                        {
                            Console.WriteLine($"The total amount spent on Skate outings is: {_outsRepo.TotalAllOutingsByType(Event.Skate)}");
                        }

                        if (userinput == "2")
                        {
                            Console.WriteLine($"The total amount spent on bowling outings is {_outsRepo.TotalAllOutingsByType(Event.Snowboarding)}");
                        }

                        if (userinput == "3")
                        {
                            Console.WriteLine($"The total amount spent on Amusement Park outings is: {_outsRepo.TotalAllOutingsByType(Event.Skydiving)}");
                        }

                        if (userinput == "4")
                        {
                            Console.WriteLine($"The total amount spent on Concert outings is: {_outsRepo.TotalAllOutingsByType(Event.Concert)}");
                        }

                        if (userinput == "5")
                        {
                            Console.WriteLine($"The total amount spent on Undefined outings is: {_outsRepo.TotalAllOutingsByType(Event.Misc)}");
                        }
                    }
                }
            }
        }
    }
}