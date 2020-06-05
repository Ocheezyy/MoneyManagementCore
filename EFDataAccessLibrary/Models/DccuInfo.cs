using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFDataAccessLibrary.Models
{
    public class DccuInfo
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Transaction_Number { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [MaxLength(200)]
        public string Memo { get; set; }
        [MaxLength(20)]
        public string Amount_Debit { get; set; }
        //public double Amount_Credit { get; set; }
        public double Balance { get; set; }
        //[MaxLength(10)]
        //public string Check_Number { get; set; }
        [MaxLength(30)]
        public string Fees { get; set; }
        public double Principal { get; set; }
    }
}
