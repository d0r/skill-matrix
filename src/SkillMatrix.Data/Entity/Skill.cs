using System.Collections.Generic;

namespace SkillMatrix.Data.Entity
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<LevelInfo> Levels { get; set; }
    }
}
