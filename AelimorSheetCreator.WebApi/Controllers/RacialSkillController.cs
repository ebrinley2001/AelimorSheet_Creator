using AelimorSheetCreator.BC;
using AelimorSheetCreator.Models;
using Microsoft.AspNetCore.Mvc;

namespace AelimorSheetCreator.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RacialSkillController : ControllerBase
    {
        private readonly IRacialSkillBc _racialSkillBc;

        public RacialSkillController(IRacialSkillBc racialSkillBc)
        {
            _racialSkillBc = racialSkillBc;
        }

        // GET: api/<RacialSkillContoller>s
        [HttpGet]
        public async Task<IEnumerable<RacialSkill>> Get()
        {
            return await _racialSkillBc.GetCollectionAsync();
        }

        // GET api/<RacialSkillContoller>/5
        [HttpGet("{id}")]
        public async Task<RacialSkill> Get(int id)
        {
            return await _racialSkillBc.GetByIdAsync(id);
        }

        // POST api/<RacialSkillContoller>
        [HttpPost]
        public async Task Post([FromBody] RacialSkill newRacialSkill)
        {
            await _racialSkillBc.CreateAsync(newRacialSkill);
        }

        // PUT api/<RacialSkillContoller>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] RacialSkill newRacialSkill)
        {
            RacialSkill oldRacialSkill = await _racialSkillBc.GetByIdAsync(id);

            if (oldRacialSkill != null)
            {
                oldRacialSkill.RacialSkillName = newRacialSkill.RacialSkillName;
                oldRacialSkill.StaminaCost = newRacialSkill.StaminaCost;
                oldRacialSkill.Limit = newRacialSkill.Limit;
                oldRacialSkill.XpCost = newRacialSkill.XpCost;
                oldRacialSkill.RaceId = newRacialSkill.RaceId;

                await _racialSkillBc.UpdateAsync(oldRacialSkill);
            }
        }

        // DELETE api/<RacialSkillContoller>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _racialSkillBc.DeleteByIdAsync(id);
        }
    }
}
