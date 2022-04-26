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

        public List<Attribute> Attributes = new List<Attribute>();
        public List<Class> Classes = new List<Class>();
        public Dictionary<Skill, int> Skills = new Dictionary<Skill, int>();
    }
}
