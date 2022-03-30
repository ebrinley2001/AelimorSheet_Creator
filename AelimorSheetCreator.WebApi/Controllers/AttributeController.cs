using AelimorSheetCreator.BC;
using Microsoft.AspNetCore.Mvc;
using Attribute = AelimorSheetCreator.Models.Attribute;

namespace AelimorSheetCreator.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeController : ControllerBase
    {
        private readonly IAttributeBc _attributeBc;

        public AttributeController(IAttributeBc attributeBc)
        {
            _attributeBc = attributeBc;
        }

        // GET: api/<AttributeController>s
        [HttpGet]
        public async Task<IEnumerable<Attribute>> Get()
        {
            return await _attributeBc.GetCollectionAsync();
        }

        // GET api/<AttributeController>/5
        [HttpGet("{id}")]
        public async Task<Attribute> Get(int id)
        {
            return await _attributeBc.GetByIdAsync(id);
        }

        // POST api/<AttributeController>
        [HttpPost]
        public async Task<int> Post([FromBody] Attribute newAttribute)
        {
            return await _attributeBc.CreateAsync(newAttribute);
        }

        // PUT api/<AttributeController>/5
        [HttpPut("{id}")]
        public async Task<int> Put(int id, [FromBody] Attribute newAttribute)
        {
            Attribute oldAttribute = await _attributeBc.GetByIdAsync(id);

            if (oldAttribute != null)
            {
                oldAttribute.AttributeName = newAttribute.AttributeName;

                return await _attributeBc.UpdateAsync(oldAttribute);
            }
            return 0;
        }

        // DELETE api/<AttributeController>/5
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {
            Attribute entity = await _attributeBc.GetByIdAsync(id);
            return await _attributeBc.DeleteByIdAsync(entity);
        }
    }
}
