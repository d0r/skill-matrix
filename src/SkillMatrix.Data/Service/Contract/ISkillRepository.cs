using System.Collections.Generic;
using SkillMatrix.Data.Entity;

namespace SkillMatrix.Data.Service.Contract
{
    public interface ISkillRepository
    {
        IEnumerable<Skill> GetSkills();
    }
}
