using System.ComponentModel.DataAnnotations;

namespace Tessera.Employee.API.Model
{
    public class EmployeeModel
    {
        [Required]
        public int? Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [Phone]
        public string? PhoneNumber { get; set; }
        [Required]
        public DateTime? BirthDate { get; set; }
        [Required]
        public DateTime? HiredDate { get; set; }
        [Required]
        public string? JobTitle { get; set; }
        public int? ReportsTo { get; set; }
    }

    public enum JobTitle
    {
        TS,
        STE,
        ATE,
        TE,
        ADM,
        STM,
        TM
    }
}
