using AelimorSheetCreator.Models;
using System.Threading.Tasks;

namespace AelimorSheetCreator.BC.BuisinessComponents.CharacterValidation
{
    public interface ICharacterValueRetrievalBc
    {
        public Task<Character> RetrieveCharacterValues(CharacterValues values);
    }
}
