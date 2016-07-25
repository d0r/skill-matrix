using System.Collections.Generic;
using SkillMatrix.Data.Model;

namespace SkillMatrix.Data.Service.Contract
{
    public interface ISkillRepository
    {
        IEnumerable<Skill> GetSkills();
    }
}
