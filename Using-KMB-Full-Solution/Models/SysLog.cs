﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhendisAsci.Web.Models
{
    [Table("syslog")]
    public class SysLog
    {
        [Key]
        public Guid ID { get; set; }
        public string Source { get; set; }
        public string Message { get; set; }

        [StringLength(255)]
        public string Username { get; set; }
        public string StackTrace { get; set; }
        public DateTime OccuredDate { get; set; }
    }
}
