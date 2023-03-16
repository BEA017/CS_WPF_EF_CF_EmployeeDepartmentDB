using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_EF_CF_EmployeeDepartmentDB.Models
{
    public class MyConsolidateTable
    {
     
        public int EmployeeId { get; set; }


        public string FirstName { get; set; }

        
        public string LastName { get; set; }


        public string Title { get; set; }
        
        public int DepartmentId { get; set; }
    }
}
