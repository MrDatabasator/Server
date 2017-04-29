using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1
{
    [DataContract]
    [Table("navrh_task_v1")]
    public class tbTask
    {        
        [Key, DataMember, Browsable(false)]
        public int Id { get; set; }
        [DataMember]
        public int DaemonId { get; set; }
        [DataMember, Column("KornExpression")]
        public string KronExpression { get; set; }
        [DataMember]
        public int TaskFinished { get; set; }
        [DataMember]
        public virtual List<tbDestination> LDestination { get; set; }
        [DataMember]
        public DateTime LastTaskCommit { get; set; }
        [DataMember]
        public string TaskName { get; set; }

        public override string ToString()
        {
            return TaskName +" "+ DaemonId +" " +TaskFinished;
        }
    }
}
