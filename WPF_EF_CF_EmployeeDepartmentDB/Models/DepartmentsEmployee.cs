using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_EF_CF_EmployeeDepartmentDB.Models
{
     public class DepartmentsEmployee
    {

        public int DepartmentId { get; set; }

        public int EmployeeId { get; set; }

       [ForeignKey("DepartmentId")]
        public virtual Department Departments { get; set; }

       [ForeignKey("EmployeeId")]
        public virtual Employee Employees { get; set; }
    }
}
