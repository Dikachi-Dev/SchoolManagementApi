using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolManagementApi.Models;

namespace SchoolManagementApi.Data
{
    public class SchoolManagementApiContext : DbContext
    {
        public SchoolManagementApiContext (DbContextOptions<SchoolManagementApiContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Course { get; set; } = default!;
        public DbSet<CourseReg> CourseRegs { get; set; } = default!;
        public DbSet<Staff> Staffs { get; set; } = default!;
        public DbSet<Student> Students { get; set; } = default!;
    }
}
