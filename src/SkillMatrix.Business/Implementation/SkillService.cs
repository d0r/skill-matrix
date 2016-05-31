using System;
using System.Collections.Generic;
using AutoMapper;
using SkillMatrix.Business.Interfaces;
using SkillMatrix.Business.Models;
using SkillMatrix.Data.Interfaces;

namespace SkillMatrix.Business.Implementation
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