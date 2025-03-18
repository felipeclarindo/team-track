using src.library.AbstractClass;

namespace src.library.Models
{
    public class Senior : TeamMember
    {
        public Senior(string name, int levelExperience, string department, string teamMemberDetails) : base(name, levelExperience, department, teamMemberDetails) {}
    }
}
