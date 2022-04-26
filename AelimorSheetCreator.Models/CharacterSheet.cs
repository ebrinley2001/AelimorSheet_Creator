using System.Collections.Generic;

namespace AelimorSheetCreator.Models
{
    public class CharacterSheet
    {
        public string CharacterName { get; set; }
        public int XpTotal { get; set; }
        public int XpSpent { get; set; }
        public int LevelNum { get; set; }
        public string RaceName { get; set; }
        public List<string> Classes { get; set; }
        public List<string> Attributes { get; set; }
        public int Hp { get; set; }
        public int Stamina { get; set; }
        public int WearLimit { get; set; } = 15;
        public int NatArmor { get; set; } = 0;
        public Dictionary<string, int> Skills { get; set; }
    }
}

