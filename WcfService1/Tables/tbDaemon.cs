using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WcfService1
{
    [Table("navrh_daemon_v1")]
    public class tbDaemon
    {
        [Key]
        public int Id { get; set; }
        public string DaemonName { get; set; }
        public string PcName { get; set; }
        public DateTime LastActive { get; set; }

    }
}