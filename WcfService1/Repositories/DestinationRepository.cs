﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class DestinationRepository
    {
        private MyContext _context = new MyContext();

        public List<tbDestination> FindAll()
        {
            return this._context.Destination.ToList<tbDestination>();
        }
        public tbDestination FindById(int id)
        {
            return this._context.Destination.Find(id);
        }
        public void InsertDestination(tbDestination d)
        {
            this._context.Destination.Add(d);
            this._context.SaveChanges();
        }
        public void Remove(tbDestination d)
        {
            this._context.Destination.Remove(d);
            this._context.SaveChanges();
        }
    }
}