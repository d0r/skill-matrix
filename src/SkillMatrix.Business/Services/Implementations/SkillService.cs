using System.Collections.Generic;
using AutoMapper;
using SkillMatrix.Business.Models;
using SkillMatrix.Business.Services.Contracts;
using SkillMatrix.Data.Services.Contracts;

namespace SkillMatrix.Business.Services.Implementations
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
