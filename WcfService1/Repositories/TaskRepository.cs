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
        public void InsertTask(tbTask d)
        {
            this._context.Task.Add(d);
            this._context.SaveChanges();
        }
        public void Remove(tbTask d)
        {
            this._context.Task.Remove(d);
            this._context.SaveChanges();
        }
    }
}