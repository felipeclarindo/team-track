using src.library.AbstractClass;

namespace src.library.Models
{
    public class Junior : TeamMember
    {
        public Junior(string name, int levelExperience, string role, string department) : base(name, levelExperience, role, department) {}
    }
}
