using src.library.AbstractClass;

namespace src.library.Models
{
    public class Owner : TeamOwner
    {
        public Owner(string name, string department, string ownerDetails) : base(name, department, ownerDetails) {}

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager Info: {Name}");
            Console.WriteLine($"Department: {Department}");
        }
    }
}
