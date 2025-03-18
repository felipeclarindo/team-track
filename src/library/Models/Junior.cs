using src.library.AbstractClass;

namespace src.library.Models
{
    public class Junior : TeamMember
    {
        public Junior(string name, int levelExperience, string department, string teamMemberDetails) : base(name, levelExperience, department, teamMemberDetails) {}
    }
}
