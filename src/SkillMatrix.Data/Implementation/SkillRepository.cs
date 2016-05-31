using System.Collections.Generic;
using SkillMatrix.Data.Models;
using SkillMatrix.Data.Interfaces;

namespace SkillMatrix.Data.Implementation
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