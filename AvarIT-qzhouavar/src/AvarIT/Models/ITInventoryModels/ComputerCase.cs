﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvarIT.Models.ITInventoryModels
{
    public class ComputerCase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Avar Tag Number")]
        public string AvarTagNumber { get; set; }

        [Required]
        [Display(Name = "Assigned User")]
        public string User { get; set; }

        [Required]
        public string Brand { get; set; }

     
        [Display(Name = "Machine Name")]
        public string MachineName { get; set; }

      
        [Display(Name = "Office Location")]
        public string  OfficeLocation { get; set; }


        [Display(Name = "Serial No.")]
        public string SerialNumber { get; set; }

        [Required]
        [Display(Name = "Model Series")]
        public string ModelSeries { get; set; }

        [Required]
        [Display(Name = "Model No")]
        public string ModelNo { get; set; }

        [Display(Name = "Screen Size (Laptop)")]
        public string LaptopScreenSize { get; set; }

        [Required]
        [Display(Name = "CPU Type")]
        public string CPUType { get; set; }

        [Required]
        [Display(Name = "CPU Frequency")]
        public string CPUFrequency { get; set; }

        [Required]
        [Display(Name = "Memory size")]
        public string MemorySize { get; set; }

        [Required]
        [Display(Name = "HDD size")]
        public string HDDSize { get; set; }

        [Required]
        [Display(Name = "OEM Operating System")]
        public string OEMOperatingSystem { get; set; }
     

        [Display(Name = "OEM License")]
        public string OEMLicense { get; set; }

        [Required]
        [Display(Name = "Upgraded To")]
        public string UpgradedTo{ get; set; }

        [Display(Name = "Upgrade License")]
        public string UpgradeLicense { get; set; }

        [Display(Name = "LAN MAC")]
        public string LANMAC { get; set; }

        [Display(Name = "WLAN MAC")]
        public string WLANMAC { get; set; }

        [Display(Name = "Order No")]
        public string OrderNo{ get; set; }


        [Display(Name = "Purchase Date")]
        [DataType(DataType.Date)]
        public DateTime? PurchaseDate  { get; set; }

        public string Warranty { get; set; }

        [DataType(DataType.Currency)]
        public decimal? Cost { get; set; }

        [DataType(DataType.MultilineText)]
        public string Note { get; set; }

      
        public bool Retired { get; set; }
        
    }
}
