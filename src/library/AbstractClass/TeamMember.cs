using src.library.Interface;

namespace src.library.AbstractClass
{
    public abstract class TeamMember : ITeamMember
    {
        public string Name { get; set; }
        protected int LevelExperience { get; set; }
        internal string Role { get; set; }
        protected internal string Department { get; set; }

        public TeamMember(string name, int levelExperience, string role, string department)
        {
            Name = name;
            LevelExperience = levelExperience;
            Role = role;
            Department = department;
        }
        
    }
}
