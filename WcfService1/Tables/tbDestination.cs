using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WcfService1
{
    [Table("navrh_destination_v1")]
    public class tbDestination
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual List<tbTask> LTask { get; set; }
    }
}
