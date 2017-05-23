using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class LogRepository
    {
        private MyContext _context = new MyContext();

        public List<tbLog>FindAll()
        {
            return this._context.Log.ToList<tbLog>();
        }
        public tbLog FindById(int id)
        {
            return this._context.Log.Find(id);
        }
        public void InsertLog(tbLog d)
        {
            this._context.Log.Add(d);
            this._context.SaveChanges();
        }
        public void Remove(tbLog d)
        {
            this._context.Log.Remove(d);
            this._context.SaveChanges();
        }
    }
}