using AelimorSheetCreator.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace AelimorSheetCreator.Sdk.Proxy
{
    public class CharacterProxy : BaseApiProxy<CharacterValues>, ICharacterProxy
    {
        public CharacterProxy(IConfiguration config) :
            base(config,
                ProxyConstants.Controller,
                ProxyConstants.CharacterEndpoint)
        {
        }

        public async Task<CharacterSheet> SubmitCharacter(CharacterValues characterValues)
        {
            HttpResponseMessage response;
            string json = TypeConverter.ClassToJson<CharacterValues>(characterValues);
            using (var client = new HttpClient())
            {
                response = await CallClientWithBody(client.PostAsync, json);
            }
            return TypeConverter.JsonToClass<CharacterSheet>(await response.Content.ReadAsStringAsync());
        }

    }
}
