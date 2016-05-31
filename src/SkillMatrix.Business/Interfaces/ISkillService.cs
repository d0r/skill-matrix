using System.Collections.Generic;
using SkillMatrix.Business.Models;

namespace SkillMatrix.Business.Interfaces
{
    public interface ISkillService
    {
        IEnumerable<Skill> GetSkills();
    }
}