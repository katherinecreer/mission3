using System;
using System.Collections.Generic;

namespace mission3
{
    class Program
    {
        static List<Foods> inventory = new List<Foods>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nFood Bank Inventory System");
                Console.WriteLine("1. Add Food Item");
                Console.WriteLine("2. Delete Food Item");
                Console.WriteLine("3. Print Current Food Items");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddFoods();
                        break;
                    case "2":
                        DeleteFoodItem();
                        break;
                    case "3":
                        PrintInventory();
                        break;
                    case "4":
                        Console.WriteLine("Exiting the program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddFoods()
        {
            Console.Write("Enter the name of the food item: ");
            string name = Console.ReadLine();

            Console.Write("Enter the category of the food item (e.g., Fruit, Canned Goods, Dairy): ");
            string category = Console.ReadLine();

            int quantity;
            do
            {
                Console.Write("Enter the quantity (positive value): ");
            } while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0);

            DateTime expirationDate;
            do
            {
                Console.Write("Enter the expiration date (yyyy-MM-dd): ");
            } while (!DateTime.TryParse(Console.ReadLine(), out expirationDate));

            Foods newItem = new Foods(name, category, quantity, expirationDate);
            inventory.Add(newItem);
            Console.WriteLine("Food item added successfully!");
        }

        static void DeleteFoodItem()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("No items to delete.");
                return;
            }

            PrintInventory();

            int index;
            do
            {
                Console.Write("Enter the number of the item to delete: ");
            } while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > inventory.Count);

            inventory.RemoveAt(index - 1);
            Console.WriteLine("Food item deleted successfully!");
        }

        static void PrintInventory()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("No food items in the inventory.");
                return;
            }

            Console.WriteLine("\nCurrent Food Items:");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i]}");
            }
        }
    }
}
