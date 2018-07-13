using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSiteMVC.Models
{
    public class CityCategory
    {
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

    }
}