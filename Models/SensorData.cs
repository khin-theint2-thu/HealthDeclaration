using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CovidHealthDeclarationForm.Models
{
    public class SensorData
    {
        [Key]
        [MaxLength(50)]
        public string SensorDataID { get; set; }
        [MaxLength(50)]
        public string? DeviceID { get; set; }
        [MaxLength(50)]
        public string? DeviceType { get; set; }
        [MaxLength(50)]
        public string? DeviceName { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Temperature { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Humidity { get; set; }
        public bool? Occupancy { get; set; }
    }
}
