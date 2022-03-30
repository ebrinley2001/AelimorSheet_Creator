using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AelimorSheetCreator.Models
{
    [Table("RacialSkill")]
    public class RacialSkill
    {
        [Key]
        public int RacialSkillId { get; set; }
        [Required]
        public string RacialSkillName { get; set; }
        public int StaminaCost { get; set; }
        public string Limit { get; set; }
        public int XpCost { get; set; }
        public int RaceId { get; set; }
        public string Description { get; set; }
        [Required]
        public bool CombatSkill { get; set; }

        public virtual Race Race { get; set; }
    }
}
