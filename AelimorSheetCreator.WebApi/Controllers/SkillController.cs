using AelimorSheetCreator.BC;
using AelimorSheetCreator.Models;
using Microsoft.AspNetCore.Mvc;

namespace AelimorSheetCreator.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly ISkillBc _skillBc;

        public SkillController(ISkillBc skillBc)
        {
            _skillBc = skillBc;
        }

        // GET: api/<SkillController>s
        [HttpGet]
        public async Task<IEnumerable<Skill>> Get()
        {
            return await _skillBc.GetCollectionAsync();
        }

        // GET api/<SkillController>/5
        [HttpGet("{id}")]
        public async Task<Skill> Get(int id)
        {
            return await _skillBc.GetByIdAsync(id);
        }

        // POST api/<SkillController>
        [HttpPost]
        public async Task Post([FromBody] Skill newSkill)
        {
            await _skillBc.CreateAsync(newSkill);
        }

        // PUT api/<SkillController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Skill newSkill)
        {
            Skill oldSkill = await _skillBc.GetByIdAsync(id);

            if (oldSkill != null)
            {
                oldSkill.SkillName = newSkill.SkillName;
                oldSkill.XpCost = newSkill.XpCost;
                oldSkill.StaminaCost = newSkill.StaminaCost;
                oldSkill.Prereqs = newSkill.Prereqs;
                oldSkill.Limit = newSkill.Limit;
                oldSkill.CombatSkill = newSkill.CombatSkill;
                oldSkill.ClassId = newSkill.ClassId;
                oldSkill.AttributeId = newSkill.AttributeId;

                await _skillBc.UpdateAsync(oldSkill);
            }
        }

        // DELETE api/<SkillController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _skillBc.DeleteByIdAsync(id);
        }
    }
}
