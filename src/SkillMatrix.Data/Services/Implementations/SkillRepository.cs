using System.Collections.Generic;
using System.Linq;
using SkillMatrix.Data.Entities;
using SkillMatrix.Data.Services.Contracts;

namespace SkillMatrix.Data.Services.Implementations
{
    public class SkillRepository : ISkillRepository
    {
        private readonly SkillMatrixContext _skillMatrixContext;

        public SkillRepository(SkillMatrixContext skillMatrixContext)
        {
            _skillMatrixContext = skillMatrixContext;
        }

        public IEnumerable<Skill> GetSkills()
        {
            using (var dbContext = _skillMatrixContext)
            {
                return dbContext.Skill.ToList();
            }
        }
    }
}
