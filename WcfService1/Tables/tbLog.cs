using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WcfService1
{
    [Table("navrh_log_v1")]
    public class tbLog
    {
        [Key]
        public int Id { get; set; }
        public int DaemonId { get; set; }
        public string Message { get; set; }
    }
}