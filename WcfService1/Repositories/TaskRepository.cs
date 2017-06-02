using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace WcfService1
{
    public class TaskRepository
    {
        private MyContext _context = new MyContext();

        public List<tbTask> FindAll()
        {
            return this._context.Task.ToList<tbTask>();
        }
        public tbTask FindById(int id)
        {
            return this._context.Task.Find(id);
        }
        /*public List<tbTask> FindByDestinationId(int id)
        {
            return this._context.Task.Where(x => x.).ToList<tbTask>();
        }*/
        public void InsertTask(tbTask d)
        {
            this._context.Task.Add(d);
            this._context.SaveChanges();
        }
        public void Remove(tbTask d)
        {
            if (d != null)
            {
                tbTask dbTask = this.FindById(d.Id);
                this._context.Task.Remove(dbTask);
                this._context.SaveChanges();
            }
        }
        public void Update(tbTask t)
        {
            //this._context.Daemon.Attach(d);
            //this._context.Entry(d).State = System.Data.Entity.EntityState.Modified;           
            this._context.Task.AddOrUpdate(t);
            this._context.SaveChanges();

        }
    }
}