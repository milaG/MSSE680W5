﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;
using ServiceLayer;


namespace BusinessLayer
{
    public class ManagerDVD
    {
           public void InsertDVD(DVD dvd)
        {
            var dvdRepo = ServiceLayer.Factory.Creates("DVD");
            dvdRepo.Insert(dvd);
        }

        public void Update(DVD dvd)
        {
            var dvdRepo = ServiceLayer.Factory.Creates("DVD");
            dvdRepo.Update(dvd);
        }

        public void Delete(DVD dvd)
        {
            var dvdRepo = ServiceLayer.Factory.Creates("DVD");
            dvdRepo.Delete(dvd);
        }
        
        public IQueryable<DVD> GetAll()
        {
            var dvdRepo = ServiceLayer.Factory.Creates("DVD");
            return (dvdRepo.GetAll().OfType<DVD>());
        }

        public IQueryable<DVD> SearchByTitle(string title)
        {
            var dvdRepo = ServiceLayer.Factory.Creates("DVD");
            return (dvdRepo.GetBySpecificKey("DvdTitle", title).OfType<DVD>());
        }
    }
}
