using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AelimorSheetCreator.Models
{
    [Table("Level")]
    public class Level
    {
        [Key]
        public int LevelId { get; set; }
        [Required]
        public int LevelNum { get; set; }
        public int XpAmount { get; set; }
        public int BaseHp { get; set; }
        public int BaseIncreaseStamina { get; set; }
        public int AvailAttrib { get; set; }
        public int AvailRoles { get; set; }
    }
}

