using AelimorSheetCreator.BC;
using AelimorSheetCreator.Models;
using Microsoft.AspNetCore.Mvc;

namespace AelimorSheetCreator.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        private readonly IRaceBc _raceBc;

        public RaceController(IRaceBc raceBc)
        {
            _raceBc = raceBc;
        }

        // GET: api/<RaceController>s
        [HttpGet]
        public async Task<IEnumerable<Race>> Get()
        {
            return await _raceBc.GetCollectionAsync();
        }

        // GET api/<RaceController>/5
        [HttpGet("{id}")]
        public async Task<Race> Get(int id)
        {
            return await _raceBc.GetByIdAsync(id);
        }

        // POST api/<RaceController>
        [HttpPost]
        public async Task<int> Post([FromBody] Race newRace)
        {
            return await _raceBc.CreateAsync(newRace);
        }

        // PUT api/<RaceController>/5
        [HttpPut("{id}")]
        public async Task<int> Put(int id, [FromBody] Race newRace)
        {
            Race oldRace = await _raceBc.GetByIdAsync(id);

            if (oldRace != null)
            {
                oldRace.RaceName = newRace.RaceName;

                return await _raceBc.UpdateAsync(oldRace);
            }
            return 0;
        }

        // DELETE api/<RaceController>/5
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {
            Race entity = await _raceBc.GetByIdAsync(id);
            return await _raceBc.DeleteByIdAsync(entity);
        }
    }
}
