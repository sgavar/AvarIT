using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace AvarIT.Models.InventoryModels
{
    public class OperationSystem
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
