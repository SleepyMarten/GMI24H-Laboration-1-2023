using LinkedList;
using Prometheus;
using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class MainClass
    {
        public static void Main(string[] args)
        {


            ListReferencedBased LinkedList = new ListReferencedBased();
            ListIndexOutOfBoundsException ex = new ListIndexOutOfBoundsException();
            Person person = null;
            int count = 0;
            int choice = 0;
            void creatDummy()
            {
                if(LinkedList.size() != null)
                {
                    Console.WriteLine("Cannot creat dummy, a list already exists.");
                }
                else
                {
                    Console.WriteLine("Dummy list created has been created");
                    LinkedList.insert(1, new Person("Atti", 24, "Student"));
                    LinkedList.insert(2, new Person("Mikael", 25, "Student"));
                    LinkedList.insert(3, new Person("Axel", 27, "Student"));
                    LinkedList.insert(4, new Person("Hans", 30, "Student"));
                    LinkedList.insert(5, new Person("Rikard", 30, "Student"));
                }

            }

            void anyKey() //Simple method for for press any key to as a checkpoint in the program.
            {
                Console.WriteLine("\nPRESS ANY KEY TO CONTINUE\n");
                Console.ReadKey();
            }

            ///<summary>
            ///<para>
            ///Method to output and show contents of the list.
            /// </para>
            /// </summary>
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
<<<<<<< Updated upstream
                        Console.WriteLine($"Index: {count} || Name:{person.getAll()}");
=======
                        Console.WriteLine($"Index: {count} || {person.getAll()}");
                        //IF only want to show name and not other information in list.
                        //Console.WriteLine($"Index: {count} || Name:{person.getName()}");

>>>>>>> Stashed changes
                    }
                    Console.WriteLine("End of list\n");
                    count = 0;

                }
            }
            ///<summary>
            ///<para>
            ///Method to show a spesific user from the list.
            /// </para>
            /// </summary>
            void showUser()
            {
                Console.WriteLine("Which user do you want to see information on?");
                Console.WriteLine($"Current list: ");
                outputer();
                Console.WriteLine("Please input INDEX NUMBER of the user: ");
                int indexNumber = Convert.ToInt32(Console.ReadLine());
                try
                {
                    person = (Person)LinkedList.get(indexNumber);
                    if (person != null)
                    {
                        Console.WriteLine($"{person.getAll()}");
                    }
                }
                catch
                {
                    ex.indexOutOfBoundShowUser();
                }


            }
            ///<summary>
            ///<para>
            ///Method to add/insert a user to the list.
            /// </para>
            /// </summary>
            void addUser()
            {
                Console.WriteLine("Please input user information");
                
                try
                {
                    Console.WriteLine("Input index number [USE NUMBERS (INTEGERS)]");
                    int userIndex = Convert.ToInt32(Console.ReadLine());
<<<<<<< Updated upstream
                    if (userIndex > LinkedList.size())
=======
                    //if (userIndex > LinkedList.size())
                    //{
                    //    ex.indexOutOfBoundTooHigh();
                    //    return;
                    //}
                    if (userIndex == null || userIndex == 0)
                    {
                        ex.inputCannotBeNull();
                        return;

					}
                    if(userIndex<0)
                    {
                        ex.indexOutOfBoundTooLow();
                        return;

					}
                    if (userIndex > LinkedList.size() +1)
>>>>>>> Stashed changes
                    {
                        ex.indexOutOfBoundTooHigh();
                        return;
                    }
                    if (userIndex < LinkedList.size())
                    {
                        ex.indexOutOfBoundTooLow();
                        return;
                    }
                    Console.WriteLine("Input Name [USE STRINGS]");
                    string userName = Console.ReadLine();
                    if(string.IsNullOrEmpty(userName))
                    {
                        ex.inputCannotBeNull();
                        return;
                    }
                    Console.WriteLine("Input Occupation [USE STRINGS]");
                    string userOccupation = Console.ReadLine();
                    if (string.IsNullOrEmpty(userOccupation))
                    {
                        ex.inputCannotBeNull();
                        return;
                    }
                    Console.WriteLine("Input Age [USE NUMBERS (INTEGERS)]");
                    int userAge = Convert.ToInt32(Console.ReadLine());
<<<<<<< Updated upstream
                    if (userAge > LinkedList.size())
                    {
                        ex.indexOutOfBoundTooHigh();
                        return;
                    }
                    if (userAge < LinkedList.size())
=======
                    if (userAge <=0)
>>>>>>> Stashed changes
                    {
                        ex.indexOutOfBoundTooLow();
                        return;
                    }
                    LinkedList.insert(userIndex, new Person(userName, userAge, userOccupation));

                }
                catch
                {
                    ex.wrongInputFormat();
                    return;
                }

            }
            ///<summary>
            ///<para>
            ///Method to to remove a spesific user with spesifiying index number.
            /// </para>
            /// </summary>
<<<<<<< Updated upstream
            void removeUser()
            {
                Console.WriteLine("Input index number of the user you wish to remove\n");
                outputer();
                int indexNumber = Convert.ToInt32(Console.ReadLine());
                person = (Person)LinkedList.get(indexNumber);
                LinkedList.remove(indexNumber);
                Console.WriteLine($"Removing {person.getName()}");
                Console.WriteLine("DONE REMOVING ... \nShowing current list:");
                outputer();
=======
            void removeUser() 
            {
                try
                {
					Console.WriteLine("Input index number of the user you wish to remove\n");
					outputer();
					int indexNumber = Convert.ToInt32(Console.ReadLine());
					//if (indexNumber < LinkedList.size() || indexNumber > LinkedList.size())
					//{
					//    Console.WriteLine("Index Number Cannot be Empty or out of bounds.");
					//    return;
					//}
					if (indexNumber == null || indexNumber == 0)
					{
						ex.inputCannotBeNull();
						return;

					}
					if (indexNumber < 0)
					{
						ex.indexOutOfBoundTooLow();
						return;

					}
					if (indexNumber > LinkedList.size())
					{
						ex.indexOutOfBoundTooHigh();
						return;
					}
					person = (Person)LinkedList.get(indexNumber);
					LinkedList.remove(indexNumber);
					Console.WriteLine($"Removing {person.getName()}");
					Console.WriteLine("DONE REMOVING ... \nShowing current list:");
					outputer();
				}
                catch {
                    ex.wrongInputFormat();
                }

>>>>>>> Stashed changes
            }
            ///<summary>
            ///<para>
            ///Method to remove all the user from the list.
            /// </para>
            /// </summary>
            void removeAll()
            {
                Console.WriteLine("Removing all user from list...");
                LinkedList.removeAll();
                outputer();

            }

			///<summary>
			///<para>
			///Method to chick if the list i empty
			/// </para>
			/// </summary>
			void isEmpty()
            {
                Console.WriteLine("Checking if the list is empyt..");
                if (!LinkedList.isEmpty())
                {
                    Console.WriteLine("The list was't empty");

                }
                else
                {
                    Console.WriteLine("The list was empty");
                }
            }
            ///<summary>
            ///<para>
            ///Method to create dummy list that contains persons.
            /// </para>
            /// </summary>
            creatDummy();

            do
            {
                
                Console.WriteLine("Select an option: ");
                Console.WriteLine("1. Show list of Nodes");
                Console.WriteLine("2. Show user by [index NO]");
                Console.WriteLine("3. Add / Insert user");
                Console.WriteLine("4. Remove user");
                Console.WriteLine("5. Remove all users");
                Console.WriteLine("6. Create dummy list");
<<<<<<< Updated upstream
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 7)
=======
                Console.WriteLine("7. Clear Console");
				Console.WriteLine("8. Check if a list is empty");
				Console.WriteLine("9. Exit");
                Console.Write("Enter your choice: ");

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 9)
>>>>>>> Stashed changes
                {
                    Console.WriteLine("\nInvalid choice. Please try again.\n");
                    Console.Write("Enter your choice: ");
                }

                    switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nShowing list....");
                        outputer();
                        anyKey();
                        break;
                    case 2:
                        showUser();
                        anyKey();
                        break;
                    case 3:
                        Console.WriteLine("Option 3 selected.");
                        addUser();
                        anyKey();
                        break;
                    case 4:
                        Console.WriteLine("Option 4 selected.");
                        removeUser();
                        anyKey();
                        break;
                    case 5:
                        Console.WriteLine("Option 5 selected.");
                        removeAll();
                        anyKey();
                        break;
                    case 6:
                        Console.WriteLine("Option 6 selected.");
                        creatDummy();
                        anyKey();
                        break;
                    case 7:
<<<<<<< Updated upstream
                        Console.WriteLine("Exiting program...");
                        anyKey();
=======
                        Console.Clear();
                        anyKey();
                        break;
                    case 8:
                        Console.WriteLine("Option 8 selected.");
                        isEmpty();
						anyKey();
>>>>>>> Stashed changes
                        break;
					case 9:
						Console.WriteLine("Exiting program...");
						anyKey();
						break;


<<<<<<< Updated upstream
                }
            } while (choice != 7);
=======
				}
            } while (choice != 9);
>>>>>>> Stashed changes

        }

        
    }
}