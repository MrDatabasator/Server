using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService1
{
    [DataContract]
    [Table("navrh_daemon_v1")]
    public class tbDaemon
    {
        [Key,DataMember, Browsable(false)]
        public int Id { get; set; }
        [DataMember]
        public string DaemonName { get; set; }
        [DataMember]
        public string PcName { get; set; }
        [DataMember]
        public DateTime LastActive { get; set; }
        [DataMember]
        public string IpAddress { get; set; }

    }
}