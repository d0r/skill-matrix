using AutoMapper;
using SkillMatrix.Data.Entity;

namespace SkillMatrix.Business.Infrastructure
{
    public class AutoMapperConfigurator
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Skill, Model.Skill>();
                cfg.CreateMap<LevelInfo, Model.LevelInfo>();
            });
        }
    }
}
