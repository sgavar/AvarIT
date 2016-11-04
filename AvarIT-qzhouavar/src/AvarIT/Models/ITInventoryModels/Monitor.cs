using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvarIT.Models.ITInventoryModels
{
    public class Monitor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Avar Tag Number")]
        public string AvarTagNumber { get; set; }

        [Display(Name = "Assigned User")]
        public string User { get; set; }

     
        [Display(Name = "Office Location")]
        public string OfficeLocation { get; set; }
       
        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }

      
        public string Brand { get; set; }

        [Display(Name = "Model Series")]
        public string ModelSeries { get; set; }

        [Display(Name = "Model No")]
        public string ModelNo { get; set; }

        [Display(Name = "Screen Type")]
        public string ScreenType { get; set; }

        [Display(Name = "Screen size")]
        public string ScreenSize { get; set; }

     
        public bool HDMI { get; set; }
        public bool VGA { get; set; }
        public bool DVI { get; set; }

        [Display(Name = "Order No")]
        public string OrderNo { get; set; }


        [Display(Name = "Date of purchase ")]
        [DataType(DataType.Date)]
        public DateTime? PurchaseDate { get; set; }

        public string Warranty { get; set; }

        [DataType(DataType.Currency)]
        public decimal? Cost { get; set; }

        [DataType(DataType.MultilineText)]
        public string Note { get; set; }

        public bool Retired { get; set; }


    }
}
