namespace src.library.AbstractClass
{
    file interface ITeamMember
    {
        void DisplayInfo();
    }

    public abstract class TeamMember : ITeamMember
    {
        public string Name { get; set; }
        protected int LevelExperience { get; set; }
        public string Department { get; set; }
        protected internal string TeamMemberDetails { get; set; }

        public TeamMember(string name, int levelExperience, string department, string teamMemberDetails) : base()
        {
            Name = name;
            LevelExperience = levelExperience;
            Department = department;
            TeamMemberDetails = teamMemberDetails;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Experience: {LevelExperience}, Department: {Department}");
        }
    }
}
