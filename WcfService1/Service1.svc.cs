using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void UploadString(string s)
        {
            DaemonRepository dr = new DaemonRepository();
            tbDaemon d = new tbDaemon();
            d.DaemonName = s;
            d.Id = 50;
            d.IpAddress = "adresa";
            d.LastActive = DateTime.Now;
            d.PcName = "pc name";
            dr.InsertDaemon(d);

        }
        public void UploadDaemon(Object o)
        {
            DaemonRepository dr = new DaemonRepository();             
            dr.InsertDaemon(o as tbDaemon);

        }
        public Daemon GetDaemon(Daemon o)
        {
            //test
            o.DaemonName = "Server Upravil biš";
            return o;
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
