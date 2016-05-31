using System.Collections.Generic;

namespace SkillMatrix.Data.Models
{
    public class Skill 
    {
        public string Name { get; set; }
        public IEnumerable<LevelInfo> Levels { get; set; }
    }
}