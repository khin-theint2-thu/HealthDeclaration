using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CovidHealthDeclarationForm.Models
{
    public class HealthDeclarationData
    {
        [Key]
        [MaxLength(50)]
        public string VisitorID { get; set; }
        [Required(ErrorMessage = "First Name is required.")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required.")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Phone is required.")]
        [MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        public string BuildingName { get; set; }
        public string BuildingLevel { get; set; }
        public string StreetName { get; set; }
        public string RoomNumber { get; set; }
        public string Carpark { get; set; }
        public string Lobby { get; set; }
        public string Pantry { get; set; }
        [MaxLength(50)]
        public string PostalCode { get; set; }
        [MaxLength(50)]
        public string TravelHistory { get; set; }
        [MaxLength(50)]
        public string SymptomStatus { get; set; }
        [MaxLength(50)]
        public string VaccinationStatus { get; set; }
        public bool Haveyoutakencovidtest { get; set; }
        public bool Haveyoucontactinfppl { get; set; }
        public bool TestResult { get; set; }
        public bool Areyoufullyrecovered { get; set; }
        public bool Areyouinquarantine { get; set; }
        public bool Acknowlegetheinformation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedOn { get; set; }
        [MaxLength(50)]
        public string SensorDataID { get; set; }
        public bool Active { get; set; }
    }
}
