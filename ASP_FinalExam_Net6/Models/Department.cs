using System.ComponentModel.DataAnnotations;

namespace ASP_FinalExam_Net6.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required,  MaxLength(100)]
        public string Name { get; set; }
        [Range(0, Int64.MaxValue, ErrorMessage = "The Employee Count must be greater than 0.")]
        public int EmployeeCount { get; set; }

    }
}
