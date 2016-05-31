using System.Collections.Generic;
using SkillMatrix.Data.Models;

namespace SkillMatrix.Data.Interfaces
{
    public interface ISkillRepository
    {
        IEnumerable<Skill> GetSkills();
    }
}