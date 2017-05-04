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
    [Table("navrh_destination_v1")]    
    [DataContractAttribute(IsReference = true)]
    [Serializable()]
    public class tbDestination
    {
        [Key, DataMember, Browsable(false)]
        public int Id { get; set; }
        [DataMember]
        public int TaskId { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string NetSourcePath { get; set; }
        [DataMember]
        public string NetDestinationPath { get; set; }
        
        [DataMember]
        public virtual List<tbTask> LTask { get; set; }

        public override string ToString()
        {
            return Type;
        }
    }
}
