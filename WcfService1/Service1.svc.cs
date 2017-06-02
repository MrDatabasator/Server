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
            d.RefreshRate = 5;
            dr.InsertDaemon(d);

        }

        #region UploadClasses
        public void UploadDaemon(tbDaemon o)
        {
            DaemonRepository dear = new DaemonRepository();             
            dear.InsertDaemon(o);

        }
        public void UploadTask(tbTask t)
        {
            TaskRepository tasr = new TaskRepository();
            tasr.InsertTask(t);

        }
        public void UploadLog(tbLog l)
        {
            LogRepository logr = new LogRepository();
            logr.InsertLog(l);

        }
        public void UploadDestination(tbDestination d)
        {
            DestinationRepository desr = new DestinationRepository();
            desr.InsertDestination(d);

        }
        #endregion

        #region DemonMethods
        public int UploadDaemonReference(tbDaemon o)
        {
            DaemonRepository dear = new DaemonRepository();
            dear.InsertDaemon(o);
            return dear.FindAll().LastOrDefault().Id;
        }
        public void UpdateDaemonLastActive(int id)
        {
            DaemonRepository d = new DaemonRepository();
            tbDaemon demon = d.FindById(id);
            demon.LastActive = DateTime.Now;
            d.Update(demon);
        }
        public bool CheckDeamonReference(int id)
        {
            DaemonRepository d = new DaemonRepository();
            if (id == 0)
                return false;
            try
            {
                tbDaemon demon = d.FindById(id);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public void UpdateDeamonReference(int id, tbDaemon d)
        {
            DaemonRepository dr = new DaemonRepository();
            tbDaemon daemon = dr.FindById(id);
            if(daemon != d)
                dr.Update(d);
        }
        public void UpdateTaskFinished(int id, bool finished)
        {
            TaskRepository tr = new TaskRepository();
            tbTask task = tr.FindById(id);
            if (finished)
                task.TaskFinished = 1;
            else
                task.TaskFinished = 0;
            tr.Update(task); 
        }
        public void UpdateTaskLastCommit(int id)
        {
            TaskRepository tr = new TaskRepository();
            tbTask task = tr.FindById(id);
            task.LastTaskCommit = DateTime.Now;
            tr.Update(task);
        }
        public void UpdateTaskRefrence(int id, tbTask t)
        {
            TaskRepository tr = new TaskRepository();
            tbTask task = tr.FindById(id);
            if (task != t)
                tr.Update(t);            
        }
        public bool ExistDeamonTask(int id)
        {
            TaskRepository tr = new TaskRepository();
            if (tr.FindAll().Where(x => x.DaemonId == id).ToList().Count > 0)
                return true;
            return false;
           
        }
        public List<tbTask> GetDeamonTask(int id)
        {
            TaskRepository tr = new TaskRepository();
            return tr.FindAll().Where(x => x.DaemonId == id).ToList();
        }
        public void NewLogMessage(int DaemonId, string message)
        {
            tbLog tl = new tbLog();
            LogRepository lr = new LogRepository();
            tl.DaemonId = DaemonId;
            tl.Message = message;
            lr.InsertLog(tl);
        }
        #endregion

        #region AdminMethods
        public List<tbDaemon> GetAllDaemons()
        {
            DaemonRepository dr = new DaemonRepository();
            return dr.FindAll().ToList();
        }

        public List<tbDestination> GetAllDestinations()
        {
            DestinationRepository desr = new DestinationRepository();
            return desr.FindAll().ToList();
        }
        public int UploadTaskReference(tbTask t)
        {
            TaskRepository tr = new TaskRepository();
            tr.InsertTask(t);
            return tr.FindAll().LastOrDefault().Id;
        }
        public void DeleteTask(tbTask t)
        {
            TaskRepository tr = new TaskRepository();
            tr.Remove(t);
        }        
        public void DeleteDestination(tbDestination d)
        {
            DestinationRepository dr = new DestinationRepository();
            dr.Remove(d);
        }        
        public void AutoDeleteTask(tbTask t)
        {
            TaskRepository tr = new TaskRepository();
            DestinationRepository dr = new DestinationRepository();
            foreach (tbDestination des in dr.FindByTaskId(t.Id))
                dr.Remove(des);
            tr.Remove(t);
        }
        #endregion

        public List<tbDestination> FindDestinationByTaskId(int id)
        {
            DestinationRepository desr = new DestinationRepository();
            return desr.FindByTaskId(id);
        }
        
        public List<tbTask> FindTaskByDestinationId(int id)
        {
            return new List<tbTask>();
        }

        public tbDaemon GetDaemon(tbDaemon o)
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
