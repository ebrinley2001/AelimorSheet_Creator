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
        public async Task<int> Post([FromBody] Skill newSkill)
        {
            return await _skillBc.CreateAsync(newSkill);
        }

        // PUT api/<SkillController>/5
        [HttpPut("{id}")]
        public async Task<int> Put(int id, [FromBody] Skill newSkill)
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

                return await _skillBc.UpdateAsync(oldSkill);
            }
            return 0;
        }

        // DELETE api/<SkillController>/5
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {
            Skill entity = await _skillBc.GetByIdAsync(id);
            return await _skillBc.DeleteByIdAsync(entity);
        }
    }
}
