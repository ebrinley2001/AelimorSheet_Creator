using System.Collections.Generic;

namespace AelimorSheetCreator.Models
{
    public class Character
    {
        public string CharacterName { get; set; }
        public Level Level { get; set; }
        public int XpTotal { get; set; }
        public int XpSpent { get; set; }
        public int Hp { get; set; }
        public int Stamina { get; set; }
        public int WearLimit { get; set; } = 15;
        public int NatArmor { get; set; } = 0;
        public Race Race { get; set; }
        public List<Attribute> Attributes { get; set; }
        public List<Class> Classes { get; set; }
        public Dictionary<int, Skill> Skills { get; set; }
    }
}
