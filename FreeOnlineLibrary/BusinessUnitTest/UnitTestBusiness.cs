using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainLayer;
using ServiceLayer;
using BusinessLayer;

namespace BusinessUnitTest
{
    [TestClass]
    public class UnitTestBusiness
    {
        [TestMethod]
        public void BusinessTestAddMember()
        {
            Member memb = new Member();
            memb.FirstName = "Lily";
            memb.LastName = "Davis";
            memb.Username = "user1";
            memb.Password = "111";

            ManagerMember manMemb = new ManagerMember();
            manMemb.InsertMember(memb);
        }

        [TestMethod]
        public void BusinessTestAddBook()
        {
            Book bb = new Book();
            bb.BookTitle = "the hobbit2";
            bb.Author = "tolkien";
            bb.BookDownload = "yes";

            ManagerBook manBook = new ManagerBook();
            manBook.InsertBook(bb); 
        }

        [TestMethod]
        public void BusinessTestAddDvd()
        {
            DVD dvd = new DVD();
            dvd.DvdTitle = "Superman2";
            dvd.DvdRating = "PG";

            ManagerDVD manDvd = new ManagerDVD();
            manDvd.InsertDVD(dvd);
        }

        [TestMethod]
        public void BusinessTestDeleteMember()
        {
            Member memb = new Member();
            memb.FirstName = "Mary";
            memb.LastName = "Davis";
            memb.Username = "user1";
            memb.Password = "Win123";

            ManagerMember manMemb = new ManagerMember();
            manMemb.InsertMember(memb);
            manMemb.Delete(memb);
        }

        [TestMethod]
        public void BusinessTestDeleteBook()
        {
            Book bb = new Book();
            bb.BookTitle = "Nice Story";
            bb.Author = "Susan Topas";
            bb.BookDownload = "yes";

            ManagerBook manBook = new ManagerBook();
            manBook.InsertBook(bb);
            manBook.Delete(bb);
        }

        [TestMethod]
        public void BusinessTestDeleteDvd()
        {
            DVD dvd = new DVD();
            dvd.DvdTitle = "Super Herp";
            dvd.DvdRating = "PG";

            ManagerDVD manDvd = new ManagerDVD();
            manDvd.InsertDVD(dvd);
            manDvd.Delete(dvd);
        }

    }
}
