namespace src.library.Models
{
    public class Owner
    {
        protected List<TeamMember> TeamList;

        public Owner(string name, string department) : base(name, department) {}

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager Info: {Name}")
            Console.WriteLine($"Department: {Department}");
        }
    }
}
