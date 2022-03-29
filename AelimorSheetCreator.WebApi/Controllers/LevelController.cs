using AelimorSheetCreator.BC;
using AelimorSheetCreator.Models;
using Microsoft.AspNetCore.Mvc;

namespace AelimorSheetCreator.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelController : ControllerBase
    {
        private readonly ILevelBc _levelBc;

        public LevelController(ILevelBc levelBc)
        {
            _levelBc = levelBc;
        }

        // GET: api/<LevelController>s
        [HttpGet]
        public async Task<IEnumerable<Level>> Get()
        {
            return await _levelBc.GetCollectionAsync();
        }

        // GET api/<LevelController>/5
        [HttpGet("{id}")]
        public async Task<Level> Get(int id)
        {
            return await _levelBc.GetByIdAsync(id);
        }

        // POST api/<LevelController>
        [HttpPost]
        public async Task Post([FromBody] Level newLevel)
        {
            await _levelBc.CreateAsync(newLevel);
        }

        // PUT api/<LevelController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Level newLevel)
        {
            Level oldLevel = await _levelBc.GetByIdAsync(id);

            if (oldLevel != null)
            {
                oldLevel.LevelNum = newLevel.LevelNum;
                oldLevel.XpAmount = newLevel.XpAmount;
                oldLevel.BaseHp = newLevel.BaseHp;
                oldLevel.BaseIncreaseStamina = newLevel.BaseIncreaseStamina;
                oldLevel.AvailAttrib = newLevel.AvailAttrib;
                oldLevel.AvailRoles = newLevel.AvailRoles;

                await _levelBc.UpdateAsync(oldLevel);
            }
        }

        // DELETE api/<LevelController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _levelBc.DeleteByIdAsync(id);
        }
    }
}
