using CovidHealthDeclarationForm.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CovidHealthDeclarationForm.Models
{
    public class ActivityLog
    {
        [Key]
        [MaxLength(50)]
        public string ActivityLogID { get; set; }
        public string Message { get; set; }
        [MaxLength(50)]
        public string LogLevel { get; set; }
        public string ControllerName { get; set; }
        [MaxLength(50)]
        public string ActionStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
    }
}
