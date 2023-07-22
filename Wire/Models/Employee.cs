using System.Data;
using System.ComponentModel.DataAnnotations;
namespace wire.Models
{
    public class Employee
    {

        [Range(1,999999, ErrorMessage = "The ID must be between 0 to 999999.")]
        public int EmployeeID { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage ="Please provide the First Name of the Employee.")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage ="Please provide the Last Name of the Employee.")]

        public string LastName { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage ="Please provide the Email Id of the employee.")]
        public string Email { get; set; }

        [Range(1,100,ErrorMessage ="The department ID must be between 1 to 100.")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Please provide the Department No of the employee.")]
        public int DepartmentID { get; set; }  // Foreign Key referencing Departments table

        [Range(1,100,ErrorMessage ="The role ID must be between 1 to 100")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Please provide the Role no of the employee from the above department.")]
        public int RoleID { get; set; }  // Foreign Key referencing Roles table

        
        
    }
}
