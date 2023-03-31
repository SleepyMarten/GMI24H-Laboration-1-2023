using LinkedList;
using Prometheus;
using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int count = 0;
            ListReferencedBased personList = new ListReferencedBased();
            personList.insert(1, new Person("Atti", 24));
            personList.insert(2, new Person("User-1", 25));
            personList.insert(3, new Person("User-2", 26));
            
            void outputer()
            {
                if (personList.size() == 0) Console.WriteLine("List contains 0 Nodes....");
                if (personList.size() > 0)
                {
                    Console.WriteLine($"List contains {personList.size()} Nodes\n");
                    for (int i = 1; i <= personList.size(); i++)
                    {
                        count += 1;
                        Person person = (Person)personList.get(count);
                        Console.WriteLine($"Name:{person.getName()} ID: X  Occupation: X Index: X");

                    }
                    Console.WriteLine("End of list\n");
                }
            }
            void showUser()
            {
                Console.WriteLine("Which user do you want to see information on?");
                Console.WriteLine("Please input INDEX NUMBER of the user: ");
                int indexNumber = Convert.ToInt32(Console.ReadLine());
                Person person = (Person)personList.get(indexNumber);
                Console.WriteLine($"Name:{person.getName()} ID: X  Occupation: X Index: X");

            }

            int choice = 0;

            do
            {
                Console.WriteLine("Select an option: ");
                Console.WriteLine("1. Show list of Nodes");
                Console.WriteLine("2. Show user by [index NO]");
                Console.WriteLine("3. Add / Insert user");
                Console.WriteLine("4. Remove user");
                Console.WriteLine("5. Remove all users");
                Console.WriteLine("6. Do something");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 7)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.Write("Enter your choice: ");
                }

                    switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nShowing list....");
                        outputer();
                        break;
                    case 2:
                        showUser();
                        break;
                    case 3:
                        Console.WriteLine("Option 3 selected.");
                        // Do something for option 3
                        break;
                    case 4:
                        Console.WriteLine("Option 4 selected.");
                        // Do something for option 4
                        break;
                    case 5:
                        Console.WriteLine("Option 5 selected.");
                        // Do something for option 5
                        break;
                    case 6:
                        Console.WriteLine("Option 6 selected.");
                        // Do something for option 6
                        break;
                    case 7:
                        Console.WriteLine("Exiting program...");
                        break;


                }
            } while (choice != 7);

        }

        
    }
}
//Insert
//Get
//RemoveALL
//REMOVE
//SIZE
//ERROR out of bounds