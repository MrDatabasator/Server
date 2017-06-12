using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1
{
    [Table("navrh_log_v1")]
    public class tbLog
    {
        [Key, DataMember, Browsable(false)]
        public int Id { get; set; }
        [DataMember]
        public int DaemonId { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public DateTime Time { get; set; }
        /*[DataMember, ForeignKey("DaemonId")]
        public virtual tbDaemon Daemon { get; set; }*/

        public override string ToString()
        {
            return DaemonId +" "+ Message;
        }
    }
}