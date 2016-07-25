using System.Collections.Generic;
using SkillMatrix.Business.Model;

namespace SkillMatrix.Business.Service.Contract
{
    public interface ISkillService
    {
        IEnumerable<Skill> GetSkills();
    }
}
