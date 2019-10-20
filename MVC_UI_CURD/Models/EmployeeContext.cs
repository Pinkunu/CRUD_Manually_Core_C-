using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_UI_Javascript.Models
{
    public class EmployeeContext:DbContext
    {
        //dependencyInjection
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
