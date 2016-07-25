using System.Collections.Generic;
using SkillMatrix.Data.Model;
using SkillMatrix.Data.Service.Contract;

namespace SkillMatrix.Data.Service.Implementation
{
    public class SkillRepository : ISkillRepository
    {
        public IEnumerable<Skill> GetSkills()
        {
            return new List<Skill>
            {
                new Skill
                {
                    Name = "ASP.NET Core 1.0",
                    Levels = new LevelInfo[] {
                        new LevelInfo
                        {
                            OrderIndex = 1,
                            Name = "Beginner",
                            Description = "Understands how to create and run a basic project."
                        }
                    }
                }
            };
        }
    }
}
