using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AelimorSheetCreator.Models
{
    [Table("Class")]
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        [Required]
        public string ClassName { get; set; }
        public int BaseStamina { get; set; }
        public string WeaponProf { get; set; }
        public string Description { get; set; }
        [Required]
        public bool Profession { get; set; }
        public int BaseHp { get; set; }
        public int BaseWearLimit { get; set; }
        public int BaseNatArmor { get; set; }
    }
}
