﻿using LinkedList;
using Prometheus;
using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {


            ListReferencedBased LinkedList = new ListReferencedBased();
            ListIndexOutOfBoundsException ex = new ListIndexOutOfBoundsException();

            int count = 0;
            int choice = 0;
            void creatDummy()
            {
                LinkedList.insert(1, new Person("Atti", 24,"Student"));
                LinkedList.insert(2, new Person("Mikael", 25, "Student"));
                LinkedList.insert(3, new Person("Axel", 27, "Student"));
                LinkedList.insert(4, new Person("Hans", 30, "Student"));
                LinkedList.insert(5, new Person("Rikard", 30, "Student"));
            }
            void outputer()
            {
                if (LinkedList.size() == 0) Console.WriteLine("List contains 0 Nodes....");
                if (LinkedList.size() > 0)
                {
                    Console.WriteLine($"List contains {LinkedList.size()} Nodes\n");
                    for (int i = 1; i <= LinkedList.size(); i++)
                    {
                        count += 1;
                        Person person = (Person)LinkedList.get(count);
                        Console.WriteLine($"Index: {count} || Name:{person.getAll()}");
                    }
                    Console.WriteLine("End of list\n");
                    count = 0;
                }
            }
            void showUser()
            {
                Console.WriteLine("Which user do you want to see information on?");
                Console.WriteLine("Please input INDEX NUMBER of the user: ");
                Console.WriteLine($"SIZE: {LinkedList.size()}");
                Person person = null;

                int indexNumber = Convert.ToInt32(Console.ReadLine());
                try
                {
                    person = (Person)LinkedList.get(indexNumber);
                    if (person != null)
                    {
                        Console.WriteLine($"Name:{person.getAll()}");
                    }
                }
                catch
                {
                    ex.indexOutOfBoundShowUser();
                }

            }
            void addUser()
            {
                Console.WriteLine("Please input user information");
                try
                {
                    Console.WriteLine("Input index number");
                    int userIndex = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input Name");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Input Occupation");
                    string userOccupation = Console.ReadLine();
                    Console.WriteLine("Input Age");
                    int userAge = Convert.ToInt32(Console.ReadLine());

                    LinkedList.insert(userIndex, new Person(userName, userAge, userOccupation));
                }
                catch
                {
                    ex.wrongInputFormat();
                }


            }
            creatDummy();
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
                        addUser();
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