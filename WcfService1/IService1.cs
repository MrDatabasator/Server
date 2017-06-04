using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void UploadString(string s);

        #region UploadClasses
        [OperationContract]
        void UploadDaemon(tbDaemon o);
        [OperationContract]
        void UploadDestination(tbDestination d);
        [OperationContract]
        void UploadLog(tbLog l);
        [OperationContract]
        void UploadTask(tbTask t);
        #endregion      
        #region DemonMethods
        [OperationContract]
        int UploadDaemonReference(tbDaemon o);
        [OperationContract]
        void UpdateDaemonLastActive(int id);
        [OperationContract]
        bool CheckDeamonReference(int id);
        [OperationContract]
        bool DaemonReferenceOutdated(int id, tbDaemon d);
        [OperationContract]
        void UpdateDeamonReferenceUpload(tbDaemon d);
        [OperationContract]
        tbDaemon UpdateDeamonReferenceGet(int id);
        [OperationContract]
        List<tbDestination> FindDestinationByTaskId(int id);
        [OperationContract]
        List<tbTask> FindTaskByDestinationId(int id);
        [OperationContract]
        bool ExistDeamonTask(int id);
        [OperationContract]
        List<tbTask> GetDeamonTask(int id);
        [OperationContract]
        void NewLogMessage(int DaemonId,string message);
        [OperationContract]
        void UpdateTaskFinished(int id, bool finished);
        [OperationContract]
        void UpdateTaskRefrence(int id, tbTask t);
        [OperationContract]
        void UpdateTaskLastCommit(int id);

        [OperationContract]
        List<tbDestination> GetAllDestinations();
        #endregion
        #region AdminMethods
        [OperationContract]
        List<tbDaemon> GetAllDaemons();

        [OperationContract]
        int UploadTaskReference(tbTask t);
        [OperationContract]
        void DeleteTask(tbTask t);
        [OperationContract]
        void DeleteDestination(tbDestination d);
        [OperationContract]
        void AutoDeleteTask(tbTask t); // deletes task and all its destinations
        /*[OperationContract]
        List<tbTask> GetAllTasks();*/
        #endregion

        [OperationContract]
        tbDaemon GetDaemon(tbDaemon o); 

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);




        // TODO: Add your service operations here
    }

    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
