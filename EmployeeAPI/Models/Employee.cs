using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        [Required]
        public int FortitudeLevel { get; set; }
        [Required]
        public int PrudenceLevel { get; set; }
        [Required]
        public int TemperanceLevel { get; set; }
        [Required]
        public int JudgementLevel { get; set; }
        public string? Name { get; set; }
        public int WeaponID { get; set; }
        public int ArmorID { get; set; }
        public Location Location { get; set; }
    }

    public enum Location
    {
        Control,
        Information,
        Training,
        Security,
        CentralCommand,
        Disiplinary,
        Welfare,
        Extraction,
        Record,
        Architecture,
        Reserve,
    }
}
