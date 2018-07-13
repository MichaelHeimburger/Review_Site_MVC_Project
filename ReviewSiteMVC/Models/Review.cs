using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSiteMVC.Models
{
    public class Review
    {

        [Key]
        public int ReviewID { get; set; }
        public string ReviewTitle { get; set; }
        public string ReviewDescription { get; set; }
        [Range(1, 101)]
        public int Rating { get; set; }
        public string ReviewerName { get; set; }

        [ForeignKey("CityCategory")]
        public int CityID { get; set; }
        public virtual CityCategory CityCategory { get; set; }






    }
}