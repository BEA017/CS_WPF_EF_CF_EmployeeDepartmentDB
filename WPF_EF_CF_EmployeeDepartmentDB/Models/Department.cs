using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPF_EF_CF_EmployeeDepartmentDB.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

       // [Required, StringLength(100)]
        public string Title { get; set; }
        
     //   [Required]
        public int HeadId { get; set; }
       // [ForeignKey("HeadId")]
       // public virtual Employee Employee { get; set; }

      //  [Required]
        public string Address { get; set; }

//[Required, StringLength(12)]
        public string PhoneNumber { get; set; }

        public IList<DepartmentsEmployee> DepartmentsEmployees { get; set; }

    }
}
