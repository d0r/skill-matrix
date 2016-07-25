using System.Collections.Generic;
using AutoMapper;
using SkillMatrix.Business.Model;
using SkillMatrix.Business.Service.Contract;
using SkillMatrix.Data.Service.Contract;

namespace SkillMatrix.Business.Service.Implementation
{
    public class SkillService : ISkillService
    {
        private readonly ISkillRepository _skillRepository;

        public SkillService(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public IEnumerable<Skill> GetSkills()
        {
            return Mapper.Map<IEnumerable<Skill>>(_skillRepository.GetSkills());
        }
    }
}
