using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AelimorSheetCreator.Models
{
    [Table("RacialSkill")]
    public class RacialSkill
    {
        [Key]
        public int RacialSkillId { get; set; }
        public string RacialSkillName { get; set; }
        public int StaminaCost { get; set; }
        public string Limit { get; set; }
        public int XpCost { get; set; }
        public int RaceId { get; set; }

        public virtual string RaceName { get; set; }
    }
}
