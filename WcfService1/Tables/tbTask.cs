using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WcfService1
{
    [Table("navrh_task_v1")]
    public class tbTask
    {
        [Key]
        public int Id { get; set; }
        public int DaemonId { get; set; }
        public string KornExpression { get; set; }
        public int TaskFinished { get; set; }
        [Browsable(false)]
        public virtual List<tbDestination> LDestination { get; set; }

    }
}
