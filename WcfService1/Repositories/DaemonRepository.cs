using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace WcfService1
{
    public class DaemonRepository       
    {
        private MyContext _context = new MyContext();

        public List<tbDaemon> FindAll()
        {
            try
            {
                return this._context.Daemon.ToList<tbDaemon>();
            }
            catch (Exception)
            {
                
                throw;
            }
            
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
        public void Update(tbDaemon d)
        {
            //this._context.Daemon.Attach(d);
            //this._context.Entry(d).State = System.Data.Entity.EntityState.Modified;           
            this._context.Daemon.AddOrUpdate(d);            
            /*tbDaemon x = this.FindById(d.Id);

            x.DaemonName = d.DaemonName;
            x.RefreshRate = d.RefreshRate;*/

            this._context.SaveChanges();
        
        }
        public void Test(string st)
        {
            
        } 

    }
}