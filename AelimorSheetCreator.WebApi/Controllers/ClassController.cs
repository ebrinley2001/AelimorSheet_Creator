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
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClassController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClassController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
