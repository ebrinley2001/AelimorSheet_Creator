using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AelimorSheetCreator.Models
{
    [Table("AttributeSkill")]
    public class AttributeSkill
    {
        [Key]
        public int AttributeSkillId { get; set; }
        [Required]
        public string AttributeSkillName { get; set; }
        public int XpCost { get; set; }
        public int AttributeId { get; set; }
        public int StaminaCost { get; set; }
        public string Description { get; set; }
        [Required]
        public bool CombatSkill { get; set; }

        public virtual Attribute Attribute { get; set; }
    }
}
