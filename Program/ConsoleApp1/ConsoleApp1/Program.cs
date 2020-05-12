using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> my_List = new LinkedList<string>();
            while (true)
            {
                Console.WriteLine("Welcome to Link List c#");
                Console.WriteLine("1.Add last of List");
                Console.WriteLine("2.Show the Data");
                Console.WriteLine("3.Add First Element");
                Console.WriteLine("4.Remove the First data");
                Console.WriteLine("5.Remove the Last data");
                Console.WriteLine("6.Clear List");
                Console.WriteLine("7.Exit the program");
                Console.WriteLine("Enter Your Choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 7)
                {
                    Console.WriteLine("Exit the program");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter name in List:");
                        string name = Console.ReadLine();
                        my_List.AddLast(name);//add last list
                        break;
                    case 2:
                        Console.WriteLine("The result of the List\n");
                        foreach(string str in my_List)
                        {
                            Console.WriteLine(str);//show data from list
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter a name to first List");
                        name = Console.ReadLine();
                        my_List.AddFirst(name);//add first element
                        break;
                    case 4:
                        Console.WriteLine("Remove first element success");
                        my_List.RemoveFirst();
                        break;
                    case 5:
                        Console.WriteLine("Remove Last element success");
                        my_List.RemoveLast();
                        break;
                    case 6:
                        Console.WriteLine("Remove all");
                        my_List.Clear();
                        break;
                }

            }
        }
    }
}
