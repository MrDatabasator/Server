using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}