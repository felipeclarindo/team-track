using src.library.AbstractClass;

namespace src.library.Models
{
    public class Pleno : Abstract.TeamMember
    {
        public Pleno(string name, int levelExperience, string role, string department) : base(name, levelExperience, role, department) {}
    }
}
