using AelimorSheetCreator.BC;
using AelimorSheetCreator.Models;
using Microsoft.AspNetCore.Mvc;

namespace AelimorSheetCreator.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeSkillController : ControllerBase
    {
        private readonly IAttributeSkillBc _attributeSkillBc;

        public AttributeSkillController(IAttributeSkillBc attributeSkillBc)
        {
            _attributeSkillBc = attributeSkillBc;
        }

        // GET: api/<AttributeSkillController>
        [HttpGet]
        public async Task<IEnumerable<AttributeSkill>> Get()
        {
            return await _attributeSkillBc.GetCollectionAsync();
        }

        // GET api/<AttributeSkillController>/5
        [HttpGet("{id}")]
        public async Task<AttributeSkill> Get(int id)
        {
            return await _attributeSkillBc.GetByIdAsync(id);
        }

        // POST api/<AttributeSkillController>
        [HttpPost]
        public async Task Post([FromBody] AttributeSkill newAttributeSkill)
        {
            await _attributeSkillBc.CreateAsync(newAttributeSkill);
        }

        // PUT api/<AttributeSkillController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] AttributeSkill newAttributeSkill)
        {
            AttributeSkill oldAttributeSkill = await _attributeSkillBc.GetByIdAsync(id);

            if (oldAttributeSkill != null)
            {
                oldAttributeSkill.AttributeSkillName = newAttributeSkill.AttributeSkillName;
                oldAttributeSkill.XpCost = newAttributeSkill.XpCost;
                oldAttributeSkill.AttributeId = newAttributeSkill.AttributeId;
                oldAttributeSkill.StaminaCost = newAttributeSkill.StaminaCost;

                await _attributeSkillBc.UpdateAsync(oldAttributeSkill);
            }
        }

        // DELETE api/<AttributeSkillController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _attributeSkillBc.DeleteByIdAsync(id);
        }
    }
}
