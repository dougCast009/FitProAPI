using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitProAPI.Models
{
    public class Customer
    {
        [Key]
        public int idCUstomer { get; set; }
        public string customerName { get; set; }
        public int customerPhone { get; set; }
        public string customerEmail { get; set; }
        public string notes { get; set; }
    }
}
