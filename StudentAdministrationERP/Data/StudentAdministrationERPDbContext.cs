using Microsoft.EntityFrameworkCore;
using StudentAdministrationERP.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdministrationERP.Data
{
    public class StudentAdministrationERPDbContext : DbContext
    {
        public StudentAdministrationERPDbContext(DbContextOptions<StudentAdministrationERPDbContext> options)
           : base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Degree> Degree { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<Enrolment> Enrolment { get; set; }

        public DbSet<Assessment> Assessment { get; set }
    }
}
