using AelimorSheetCreator.Models;
using System.Threading.Tasks;

namespace AelimorSheetCreator.Sdk
{
    public interface ICharacterProxy
    {
        public Task<CharacterSheet> SubmitCharacter(CharacterValues characterValues);
    }
}
