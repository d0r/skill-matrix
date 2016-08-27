using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SkillMatrix.Business.Model;
using SkillMatrix.Business.Service.Contract;
using System.Collections.Generic;

namespace SkillMatrix.Api.Controller
{
    [Route("api/[controller]")]
    public class SkillsController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILogger<SkillsController> _logger;

        private readonly ISkillService _skillService;

        public SkillsController(ISkillService skillService, ILogger<SkillsController> logger)
        {
            _skillService = skillService;
            _logger = logger;
        }

        // GET api/skills
        [HttpGet]
        public IEnumerable<Skill> Get()
        {
            _logger.LogError("Get skills!");
            return _skillService.GetSkills();
        }

        // GET api/skills/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/skills
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/skills/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/skills/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
