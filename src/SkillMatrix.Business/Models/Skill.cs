using System.Collections.Generic;

namespace SkillMatrix.Business.Models
{
    public class Skill
    {
        public string Name { get; set; }
        public IEnumerable<LevelInfo> Levels { get; set; }
    }
}