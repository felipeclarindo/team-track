using src.library.AbstractClass;

namespace src.library.Models
{
    public class Senior : Abstract.TeamMember
    {
        public Senior(string name, int levelExperience, string role, string department) : base(name, levelExperience, role, department) {}
    }
}
