using AvarIT.Models.InventoryModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvarIT.Models.InventoryViewModels
{
    public class EmployeeComputerCaseViewModel
    {
        public List<ComputerCase> computerCases;
        public SelectList users;
        public int userId { get; set; }
    }
}
