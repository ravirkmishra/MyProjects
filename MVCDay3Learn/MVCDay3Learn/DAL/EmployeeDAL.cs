using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCDay3Learn.Models;
using System.ComponentModel.DataAnnotations;

namespace MVCDay3Learn.DAL
{
    public class EmployeeDAL : DbContext
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public DbSet<EmployeeModel> ADGroupList { get; set; }

        //The below Code will be used only when the 

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<EmployeeModel>().ToTable("Admin.Inka");
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}