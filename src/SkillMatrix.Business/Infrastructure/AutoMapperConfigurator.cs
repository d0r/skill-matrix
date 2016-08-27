using AutoMapper;
using SkillMatrix.Data.Entities;

namespace SkillMatrix.Business.Infrastructure
{
    public class AutoMapperConfigurator
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Skill, Models.Skill>();
                cfg.CreateMap<LevelInfo, Models.LevelInfo>();
            });
        }
    }
}
