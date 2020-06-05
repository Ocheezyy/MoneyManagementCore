using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDataAccessLibrary.Models
{
    public class DiscInfo
    {
        public int Id { get; set; }
        public DateTime Trans_Date { get; set; }
        public DateTime Post_Date { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public double Amount { get; set; }
        public string Category { get; set; }
    }
}
