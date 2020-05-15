using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlastairMicallef_Enterprise.Models
{
    public class QualityModels
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Qualityame { get; set; }

        [Required]
        public string Description { get; set; }
    }
}