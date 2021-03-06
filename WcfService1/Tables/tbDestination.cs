﻿using System;
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
        [DataMember, Browsable(false)]
        public int TaskId { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember, Column("FullBackup")]
        public bool FullBackup { get; set; }
        [DataMember]
        public string NetSourcePath { get; set; }
        [DataMember]
        public string NetDestinationPath { get; set; }
        [DataMember]
        public string FtpServerAddress { get; set; }
        [DataMember]
        public string FtpUsername { get; set; }
        [DataMember]
        public string FtpPassword { get; set; }
        [DataMember]
        public string WorkingDirectory { get; set; }
        [DataMember]
        public string ClientMail { get; set; }
        [DataMember]
        public virtual List<tbTask> LTask { get; set; }

        public override string ToString()
        {
            if (Type == "Local")
                return "Local";
            else if (Type == "FTP")
                return "FTP";
            else if (Type == "SSH")
                return "SSH";
            return "ERROR.DO.NOT.USE";
        }
    }
}
