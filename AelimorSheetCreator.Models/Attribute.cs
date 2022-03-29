using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AelimorSheetCreator.Models
{
    [Table("Attribute")]
    public class Attribute
    {
        [Key]
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
    }
}
