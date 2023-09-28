using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace WiredBrainCoffee.EmployeeManager.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? FiestName { get; set; }
        [Required]
        [StringLength(50)]
        public string? LastName { get; set; }
        public bool IsDeveloper { get; set; }
        [Required]
        public int? DepartmrntId { get; set; }
        public Department? Department { get; set; }
    }
}
