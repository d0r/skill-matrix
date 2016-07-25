﻿using System.Collections.Generic;

namespace SkillMatrix.Data.Model
{
    public class Skill
    {
        public string Name { get; set; }
        public IEnumerable<LevelInfo> Levels { get; set; }
    }
}
