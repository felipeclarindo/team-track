using src.library.Models;
using src.library.AbstractClass;
using System.Collections.Generic;
using System;

namespace src.app
{
    class Program
    {
        internal static List<TeamMember> TeamMembers = new List<TeamMember>();

        static void Main()
        {
            Owner owner = RegisterOwner();

            while (true)
            {
                string option = MenuOptions();

                switch (option)
                {
                    case "1":
                        RegisterMember();
                        break;
                    case "2":
                        ListMembers();
                        break;
                    case "3":
                        ViewMember();
                        break;
                    case "4":
                        owner.DisplayInfo();
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }

        static string MenuOptions()
        {
            Console.WriteLine("\n--- Team Track ---");
            Console.WriteLine("1. Add Member");
            Console.WriteLine("2. List Members");
            Console.WriteLine("3. View Member");
            Console.WriteLine("4. View Owner");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string? option = Console.ReadLine(); 
            return option ?? string.Empty; 
        }

        static Owner RegisterOwner()
        {
            Console.WriteLine("Enter Owner's information:");

            Console.Write("Owner name: ");
            string? name = Console.ReadLine();

            Console.Write("Owner department: ");
            string? department = Console.ReadLine();

            Console.Write("Owner details: ");
            string? ownerDetails = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(department) || string.IsNullOrWhiteSpace(ownerDetails))
            {
                Console.WriteLine("All fields must be filled.");
                return RegisterOwner();  
            }

            Owner owner = new Owner(name, department, ownerDetails);
            Console.WriteLine($"Owner {owner.Name} from {owner.Department} registered successfully!");

            return owner;
        }

        static void RegisterMember()
        {
            Console.WriteLine("Enter Team Member's information:");

            Console.Write("Name: ");
            string? name = Console.ReadLine();

            Console.WriteLine("Enter Experience in Years (ex: 1, 3, 5):");
            string? experienceInput = Console.ReadLine();
            int experience = int.TryParse(experienceInput, out experience) ? experience : 0;

            Console.WriteLine("What's the member details?");
            string? teamMemberDetails = Console.ReadLine();

            ValidateValues(name, teamMemberDetails);

            if (experience >= 5)
            {
                Senior SeniorNewMember = new Senior(name!, experience, "Development", teamMemberDetails!);
                TeamMembers.Add(SeniorNewMember);
                Console.WriteLine($"Member {SeniorNewMember.Name} added as Senior.");
            }
            else if (experience >= 3)
            {
                Pleno PlenoNewMember = new Pleno(name!, experience, "Development", teamMemberDetails!); 
                TeamMembers.Add(PlenoNewMember);
                Console.WriteLine($"Member {PlenoNewMember.Name} added as Pleno.");
            }
            else
            {
                Junior JuniorNewMember = new Junior(name!, experience, "Development", teamMemberDetails!);  
                TeamMembers.Add(JuniorNewMember);
                Console.WriteLine($"Member {JuniorNewMember.Name} added as Junior.");
            }
        }

        static void ListMembers()
        {
            Console.WriteLine("\n--- Team Members ---");
            if (TeamMembers.Count == 0)
            {
                Console.WriteLine("No members to display.");
            }
            else
            {
                foreach (var member in TeamMembers)
                {
                    member.DisplayInfo();
                }
            }
        }

        static void ViewMember()
        {
            ListMembers();

            Console.WriteLine("Enter the name of the member you want to view:");
            string? name = Console.ReadLine();

            var member = TeamMembers.Find(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (member != null)
            {
                member.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Member not found.");
            }
        }

        static void ValidateValues(string? name, string? teamMemberDetails)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(teamMemberDetails))
            {
                Console.WriteLine("Name and details are required and can't be empty!");
            }
        }
    }
}
