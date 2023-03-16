using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_EF_CF_EmployeeDepartmentDB.Models
{
    public class MyDepartment
    {
     
        public int DepartmentId { get; set; }

         
        public string Title { get; set; }
 
        public int HeadId { get; set; }
 
  
        public string Address { get; set; }

      
        public string PhoneNumber { get; set; }
    }
}
