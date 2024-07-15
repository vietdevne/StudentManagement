using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentManage.Models;

namespace StudentManage.Data
{
    public class StudentManageContext : DbContext
    {
        public StudentManageContext (DbContextOptions<StudentManageContext> options)
            : base(options)
        {
        }

        public DbSet<StudentManage.Models.Student> Student { get; set; } = default!;
        public DbSet<StudentManage.Models.Teacher> Teacher { get; set; } = default!;
        public DbSet<StudentManage.Models.Course> Course { get; set; } = default!;
    }
}
