using System.Collections.Generic;
using System.Linq;
using SkillMatrix.Data.Entity;
using SkillMatrix.Data.Service.Contract;

namespace SkillMatrix.Data.Service.Implementation
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
