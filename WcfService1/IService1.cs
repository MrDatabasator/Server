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
        void UpdateDaemonLastActive(int id);
        [OperationContract]
        bool CheckDeamonReference(int id);
        [OperationContract]
        void UpdateDeamonReference(int id, tbDaemon d);
        [OperationContract]
        bool ExistDeamonTask(int id);
        [OperationContract]
        List<tbTask> GetDeamonTask(int id);
        #endregion
        #region AdminMethods
        [OperationContract]
        List<tbDaemon> GetAllDaemons();
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
