using AutoMapper;

namespace SkillMatrix.Business.Infrastructure
{
    public class AutoMapperConfigurator
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Data.Model.Skill, Model.Skill>();
                cfg.CreateMap<Data.Model.LevelInfo, Model.LevelInfo>();
            });
        }
    }
}
