using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvarIT.Models.ITInventoryModels
{
    public class NetWork
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Avar Tag Number")]
        public string AvarTagNumber { get; set; }

        [Display(Name = "Assigned User")]
        public string User { get; set; }

        [Display(Name = "Name/SSID")]
        public string NameOrSSID { get; set; }

    

        [Display(Name = "Office Location")]
        public string OfficeLocation { get; set; }

        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }


    
        public string Brand { get; set; }

        [Display(Name = "Model Series")]
        public string ModelSeries { get; set; }

        [Display(Name = "Model No")]
        public string ModelNo { get; set; }

        [Display(Name = "Device Type")]
        public string DeviceType { get; set; }

        [Display(Name = "Memory size")]
        public string MemorySize { get; set; }

        [Display(Name = "LAN Ports")]
        public string LANPorts { get; set; }

        [Display(Name = "LAN Speed")]
        public string LANSpeed { get; set; }

        [Display(Name = "Wireless Type")]
        public string WirelessType { get; set; }

        [Display(Name = "LAN MAC")]
        public string LANMAC { get; set; }

        [Display(Name = "WLAN MAC")]
        public string WLANMAC { get; set; }

        [Display(Name = "Order No")]
        public string OrderNo { get; set; }


        [Display(Name = "Purchase Date")]
        [DataType(DataType.Date)]
        public DateTime? PurchaseDate { get; set; }

        public string Warranty { get; set; }

        [DataType(DataType.Currency)]
        public decimal? Cost { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        public bool Managed { get; set; }
        public bool Router { get; set; }
        public bool Switch { get; set; }

        [Display(Name = "Access Point")]
        public bool AccessPoint { get; set; }

        public bool Firewall { get; set; }

        public bool Modem { get; set; }

        public bool Cabel { get; set; }

        public bool Retired { get; set; }
    }
}
