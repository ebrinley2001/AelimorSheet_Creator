using AelimorSheetCreator.BC;
using AelimorSheetCreator.Models;
using Microsoft.AspNetCore.Mvc;

namespace AelimorSheetCreator.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IClassBc _classBc;

        public ClassController(IClassBc classBc)
        {
            _classBc = classBc;
        }

        // GET: api/<ClassController>s
        [HttpGet]
        public async Task<IEnumerable<Class>> Get()
        {
            return await _classBc.GetCollectionAsync();
        }

        // GET api/<ClassController>/5
        [HttpGet("{id}")]
        public async Task<Class> Get(int id)
        {
            return await _classBc.GetByIdAsync(id);
        }

        // POST api/<ClassController>
        [HttpPost]
        public async Task Post([FromBody] Class newClass)
        {
            await _classBc.CreateAsync(newClass);
        }

        // PUT api/<ClassController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Class newClass)
        {
            Class oldClass = await _classBc.GetByIdAsync(id);

            if (oldClass != null)
            {
                oldClass.ClassName = newClass.ClassName;
                oldClass.BaseStamina = newClass.BaseStamina;
                oldClass.WeaponProf = newClass.WeaponProf;

                await _classBc.UpdateAsync(oldClass);
            }
        }

        // DELETE api/<ClassController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _classBc.DeleteByIdAsync(id);
        }
    }
}
