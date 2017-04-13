using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class DaemonRepository
        //just for upload
    {
        private MyContext _context = new MyContext();

        public List<tbDaemon> FindAll()
        {
            return this._context.Daemon.ToList<tbDaemon>();
        }
        public tbDaemon FindById(int id)
        {
            return this._context.Daemon.Find(id);
        }       
        public void InsertDaemon(tbDaemon d)
        {
            this._context.Daemon.Add(d);
            this._context.SaveChanges();
        }
        public void Remove(tbDaemon d)
        {
            this._context.Daemon.Remove(d);
            this._context.SaveChanges();
        }
    }
}