using System.Collections.Generic;
using SkillMatrix.Business.Models;

namespace SkillMatrix.Business.Services.Contracts
{
    public interface ISkillService
    {
        IEnumerable<Skill> GetSkills();
    }
}
