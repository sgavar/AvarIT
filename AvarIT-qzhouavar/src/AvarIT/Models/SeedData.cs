using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AvarIT.Data;
using System;
using System.Linq;
using AvarIT.Models.InventoryModels;

namespace AvarIT.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Employees.Any())
                {
                    return;   // DB has been seeded
                }

                context.Employees.AddRange(
                     new Employee
                     {
                         EmployeeID = 4,
                         EmployeeName = "Joan Wang",
                     },

                     new Employee
                     {
                         EmployeeID = 5,
                         EmployeeName = "Lin Wang",
                     },
           
                  new Employee
                  {
                      EmployeeID = 6,
                      EmployeeName = "Dai Lu",
                  }
                );
                context.SaveChanges();
            }
        }
    }
}
