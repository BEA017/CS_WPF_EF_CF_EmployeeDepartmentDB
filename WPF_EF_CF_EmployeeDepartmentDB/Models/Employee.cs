using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_EF_CF_EmployeeDepartmentDB.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

      //  [Required]
        public string FirstName { get; set; }

     //   [Required]
        public string LastName { get; set; }

      //  [Required]
        public DateTime Age { get; set; }

     //   [Required]
        public string Address { get; set; }
        
     //   [Required]
        public string PhotoPath { get; set; }

        public IList<DepartmentsEmployee> DepartmentsEmployees { get; set; }
    }
}
