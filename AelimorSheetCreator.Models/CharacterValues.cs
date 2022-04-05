using System.Collections.Generic;

namespace AelimorSheetCreator.Models
{
    public class CharacterValues
    {
        public string CharacterName { get; set; }
        public int XpTotal { get; set; }
        public int RaceId { get; set; }
        public List<int> ClassIds { get; set; }
        public List<int> AttributeIds { get; set; }
        public Dictionary<int, int> SkillIds { get; set; }
    }
}
