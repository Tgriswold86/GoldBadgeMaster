using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClaimsRepo claimsRepo = new ClaimsRepo();
            Item itemA = new Item(1, "Car", "Hit a deer", 5000, "11/20/1986", "11/25/1986\n");
            Item itemB = new Item(2, "Theft", "Stolen pasta maker", 500, "11/20/1986", "11/25/1986\n");
            Item itemC = new Item(3, "Car", "Hit a deer", 5000, "11/20/1986", "11/25/1986\n");
            

            claimsRepo.AddItem(itemA);
            claimsRepo.AddItem(itemB);
            claimsRepo.AddItem(itemC);
     


            bool cont = true;
            while (cont)
            {
                Console.WriteLine("What do you want to do? Choose a number.\n" +
                    "1) See all claims\n" +
                    "2) Delete a claim\n" +
                    "3) Add a new claim\n");
                string userAnswer = Console.ReadLine();

                switch (userAnswer)
                {
            
                    case "3":
                        while (true)
                        {
                            Console.WriteLine("Enter the claim id:");
                            int Cid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the claim type (Car, Home, or Theft):");
                            string cType = Console.ReadLine();
                            Console.WriteLine("Enter a claim description:");
                            string cDesc = Console.ReadLine();
                            Console.WriteLine("Amount of Damage:");
                            int AoD = int.Parse(Console.ReadLine());
                            Console.WriteLine("Date Of Accident:");
                            string DoA = (Console.ReadLine());
                            Console.WriteLine("Date Of Claim:");
                            string DoC = (Console.ReadLine());


                            Item userItem = new Item(Cid, cType, cDesc, AoD, DoA, DoC);
                            claimsRepo.AddItem(userItem);

                            Console.WriteLine("Do you want to add another item?");
                            string theAnswer = Console.ReadLine();
                            if (theAnswer == "Y" || theAnswer == "y")
                            {
                            }
                            else if (theAnswer == "n" || theAnswer == "N")
                            {
                                break;
                            }
                            break;
                        }
                        break;
                    case "2":
                        while (true)
                        {
                            Item cClaim = claimsRepo.SeeCurrentClaim();
                            Console.WriteLine(cClaim);
                            Console.WriteLine("Would you like to handle this claim now?");
                            string theAnswer = Console.ReadLine();
                            if (theAnswer == "n" || theAnswer == "N") { }
                            else if (theAnswer == "Y" || theAnswer == "y")
                            {
                                claimsRepo.RemoveItem();
                                break;
                            }
                            Console.WriteLine("Main Menu?");
                            Console.ReadLine();
                            break;
                        }
                        break;
                        case "1":
                        while (true)
                        {
                            claimsRepo.PrintList(claimsRepo.GetClaimList());
                            break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
