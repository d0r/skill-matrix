using AutoMapper;

namespace SkillMatrix.Business
{
    public class AutoMapperConfiguratior
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Data.Models.Skill, Business.Models.Skill>();
                cfg.CreateMap<Data.Models.LevelInfo, Business.Models.LevelInfo>();
            });
        }
    }
}