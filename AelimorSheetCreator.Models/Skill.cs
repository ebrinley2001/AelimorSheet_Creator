﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AelimorSheetCreator.Models
{
    [Table("Skill")]
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        [Required]
        public string SkillName { get; set; }
        public int XpCost { get; set; }
        public string StaminaCost { get; set; }
        public string Prereqs { get; set; }
        public string Limit { get; set; }
        public bool CombatSkill { get; set; }
        public int ClassId { get; set; }
        public int AttributeId { get; set; }
        public string Description { get; set; }

        public virtual Class Class { get; set; }
        public virtual Attribute Attribute { get; set; }
    }
}
