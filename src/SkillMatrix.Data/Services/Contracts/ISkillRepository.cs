using System.Collections.Generic;
using SkillMatrix.Data.Entities;

namespace SkillMatrix.Data.Services.Contracts
{
    public interface ISkillRepository
    {
        IEnumerable<Skill> GetSkills();
    }
}
