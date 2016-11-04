using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvarIT.Models.ITInventoryModels
{
    public class WebCompatibilityIssues
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Element Type")]
        public string ElementType { get; set; }

        [Display(Name = "Element Name")]
        public string ElementName { get; set; }

        [Display(Name = "Control Type")]
        public string ControlType { get; set; }

        [Display(Name = "Control Name")]
        public string ControlName { get; set; }

        [Display(Name = "Property Name")]
        public string PropertyName { get; set; }

        [Display(Name = "Issue Type")]
        public string IssueType { get; set; }

        [Display(Name = "Issue Type ID")]
        public string IssueTypeID { get; set; }

        [Url]
        [Display(Name = "Url")]
        public string Url { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

    }
}
