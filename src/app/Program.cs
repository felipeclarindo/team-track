using src.library.Models.;
using System;
using System.Collections.Generic;

class Program
{
    protected List<TeamMembers> TeamMembers = new List<>();

    static void Main()
    {
        while (true)
        {   
            RegisterOwner();

            string option = MenuOptions();

            switch ()
            {
                case "1":
                    RegisterMember();
                    break;
                case "2":
                    ListMembers();
                    break;
                case "3":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }

    static string menuOptions() {

            Console.WriteLine("\n--- Team Track ---");
            Console.WriteLine("1. Add Member");
            Console.WriteLine("2. List Members");
            Console.WriteLine("3. View Member");
            Console.WriteLine("3. Exit");
            Console.Write("Choise an option: ");
            
            string option = Console.ReadLine();
            return option;
    }

    static void RegisterOwner() {
        
    }

    static void RegisterMember()
    {
        
        Console.WriteLine("To start the system its need the owner's information.");
        Console.Write("\nOwner name: ")
        string name = Console.ReadLine();
        Console.Write("Owner department: ");
        string department = Console.ReadLine();
        Owner owner = new Owner(name, department);
    }

    static void ViewMember() {

    }

    static void ListMembers()
    {
        foreach (var member in teamMembers )
        {
            member.DisplayInfo();
        }
    }
}
