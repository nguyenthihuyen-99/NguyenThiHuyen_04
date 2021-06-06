﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenThiHuyen_04.Models
{
    [Table("TinhThanhs")]
    public class TinhThanh
    {
        [Key]
        public int MaTinhThanh { get; set; }
        public string TenTinhThanh { get; set; }
    }
}