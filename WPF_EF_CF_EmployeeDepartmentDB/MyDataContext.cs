using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_EF_CF_EmployeeDepartmentDB;
using WPF_EF_CF_EmployeeDepartmentDB.Models;

namespace WPF_EF_CF_EmployeeDepartmentDB
{
    public class MyDataContext:DbContext
    {
        public MyDataContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentsEmployee>().HasKey(x => new { x.EmployeeId, x.DepartmentId});
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<DepartmentsEmployee> DepartmentsEmployees { get; set; }
                
       
               
    }
}
