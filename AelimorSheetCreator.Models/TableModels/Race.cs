using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AelimorSheetCreator.Models
{
    [Table("Race")]
    public class Race
    {
        [Key]
        public int RaceId { get; set; }
        [Required]
        public string RaceName { get; set; }
    }
}
