using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvarIT.Models.ITInventoryModels
{
    public class Miscellaneous
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Avar Tag Number")]
        public string AvarTagNumber { get; set; }

        [Display(Name = "Item Type")]
        public string ItemType { get; set; }

        [Display(Name = "Assigned User")]
       
        public string User { get; set; }

        [Display(Name = "Machine Name")]
        public string MachineName { get; set; }

     
        [Display(Name = "Office Location")]
        public string OfficeLocation { get; set; }

        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }

        public string Brand { get; set; }

        [Display(Name = "Model Series")]
        public string ModelSeries { get; set; }

        [Display(Name = "Model No")]
        public string ModelNo { get; set; }

        public string License { get; set; }

        [Display(Name = "LAN MAC")]
        public string LANMAC { get; set; }

        [Display(Name = "WLAN MAC")]
        public string WLANMAC { get; set; }

        [Display(Name = "Order No")]
        public string OrderNo { get; set; }

        [Display(Name = "Date of purchase")]
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
