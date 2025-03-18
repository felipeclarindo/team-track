namespace src.library.AbstractClass
{
    file interface ITeamOwner
    {
        void DisplayInfo();
    }

    public abstract class TeamOwner : ITeamOwner
    {
        public string Name { get; set; }
        public string Department { get; set; }
        private protected string OwnerDetails { get; set; }

        public TeamOwner(string name, string department, string ownerDetails)
        {
            Name = name;
            Department = department;
            OwnerDetails = ownerDetails;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Department: {Department}, OwnerDetails: {OwnerDetails}");
        }
    }
}
