using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainLayer;
using ServiceLayer;

using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Collections;
using System.Data.Entity;
using System.Configuration;
using System.Linq.Expressions;


namespace ServiceUnitTest
{
    [TestClass]
    public class UnitTestService
    {
        [TestMethod]
        public void TestFactoryToInsertIntoMemberRepo()
        {
            Member memb = new Member();
            memb.FirstName = "Mary";
            memb.LastName = "Davis";
            memb.Username = "user1";
            memb.Password = "Win123";

            var memberRepo = ServiceLayer.Factory.Creates("Member");
            memberRepo.Insert(memb);
        }

        [TestMethod]
        public void TestFactoryToInsertIntoBookRepo()
        {
            Book bb = new Book();
            bb.BookTitle = "The lord of the rings";
            bb.Author = "Unknown";
            bb.BookDownload = "yes";

            var bookRepo =  ServiceLayer.Factory.Creates("Book");
            bookRepo.Insert(bb);
        }

        [TestMethod]
        public void TestFactoryToInsertIntoDVDRepo()
        {
            DVD dvd = new DVD();
            dvd.DvdTitle = "Spiderman";
            dvd.DvdRating = "PG";

            var DVDRepo = ServiceLayer.Factory.Creates("DVD");
            DVDRepo.Insert(dvd);
        }

        [TestMethod]
        public void TestFactoryToDeleteFromMemberRepo()
        {
            Member memb = new Member();
            memb.FirstName = "Mary";
            memb.LastName = "Davis";
            memb.Username = "user1";
            memb.Password = "Win123";

            var memberRepo = ServiceLayer.Factory.Creates("Member");
            memberRepo.Delete(memb);
        }

        [TestMethod]                                         
        public void TestFactoryToDeleteFromBookRepo()
        {
            Book bb = new Book();
            bb.BookTitle = "The lord of the rings";
            bb.Author = "Unknown";
            bb.BookDownload = "yes";

         //  var bookRepo = new DataRepository<Book>();
           var bookRepo = ServiceLayer.Factory.Creates("Book");
           Book deleteBook = (from del in bookRepo.GetAll() where del.BookTitle == "The Lord of the rings" select del).Single();

           bookRepo.Insert(bb);
            
            bookRepo.Delete(bb);
        }

        [TestMethod]
        public void TestFactoryToDeleteFromDVDRepo()
        {
            DVD dvd = new DVD();
            dvd.DvdTitle = "Spiderman";
            dvd.DvdRating = "PG";

            var DVDRepo = ServiceLayer.Factory.Creates("DVD");
            DVDRepo.Delete(dvd);
        }
    }
}
