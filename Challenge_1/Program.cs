using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuRepo menuRepo = new MenuRepo();
            //Item itemA = new Item(1, "Pancakes", "Fluffy fried bread with syrup", "Flour, eggs, water, butter", 5);
            //Item itemB = new Item(1, "Pancakes", "Fluffy fried bread with syrup", "Flour, eggs, water, butter", 5);
            //Item itemC = new Item(1, "Pancakes", "Fluffy fried bread with syrup", "Flour, eggs, water, butter", 5);
            //Item itemD = new Item(1, "Pancakes", "Fluffy fried bread with syrup", "Flour, eggs, water, butter", 5);
            //Item itemE = new Item(1, "Pancakes", "Fluffy fried bread with syrup", "Flour, eggs, water, butter", 5);
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("What do you want to do? Choose a number.\n" +
                    "1) Add a menu item.\n" +
                    "2) Remove a menu item.\n" +
                    "3) View List\n" +
                    "4) Exit");
                string userAnswer = Console.ReadLine();

                switch (userAnswer)
                {
                    case "1":
                        while (true)
                        {
                            Console.WriteLine("Enter the number of this menu item.");
                            int itemNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the name of the menu item.");
                            string itemName = Console.ReadLine();
                            Console.WriteLine("Enter the description of this menu item.");
                            string itemDesc = Console.ReadLine();
                            Console.WriteLine("Enter the ingredients for this menu item.");
                            string itemIngred = Console.ReadLine();
                            Console.WriteLine("Enter the price for this menu item.");
                            int itemPrice = int.Parse(Console.ReadLine());

                            Item userItem = new Item(itemNumber, itemName, itemDesc, itemIngred, itemPrice);
                            menuRepo.addItemToList(userItem);

                            Console.WriteLine("Do you want to add another item?");
                            string theAnswer = Console.ReadLine();
                            if (theAnswer == "Y" || theAnswer == "y")
                            {
                            }
                            else if (theAnswer == "n" || theAnswer == "N")
                            {
                                break;
                            }
                        }
                        break;
                    case "2":
                        while (true)
                        {
                            while (true)
                            {
                                Console.WriteLine("Do you want to delete an item?");
                                string theAnswer = Console.ReadLine();
                                if (theAnswer == "y" || theAnswer == "Y") { }
                                else if (theAnswer == "N" || theAnswer == "n")
                                {
                                    break;
                                }
                                Console.WriteLine("What show do you want to remove?");
                                string itemName1 = Console.ReadLine();
                                menuRepo.removeFromList(itemName1);
                                menuRepo.printList(menuRepo.getList());
                                Console.ReadLine();
                                break;
                            }
                            break;
                        }
                        break;
                    case "3":
                        menuRepo.printList(menuRepo.getList());
                        break;
                    case "4":
                        cont = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}