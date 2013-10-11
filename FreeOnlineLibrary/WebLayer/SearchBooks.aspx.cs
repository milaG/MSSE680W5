using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DomainLayer;
using BusinessLayer;

namespace WebLayer
{
    public partial class SearchBooks : System.Web.UI.Page
    {
        private string author;
        private string title;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            author = TextBox1.Text;

            ManagerBook manBook = new ManagerBook();
            List<Book> mylist = manBook.SearchByAuthor(author).ToList<Book>();

            Session["ObjectParameterName"] = mylist[0].Author;
            ObjectDataSource1.Select();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            title = TextBox2.Text;

            ManagerBook manBook = new ManagerBook();
            List<Book> mylist = manBook.SearchByTitle (title).ToList<Book>();

            Session["ObjectParameterName"] = mylist[0].BookTitle;
            ObjectDataSource1.Select();

        }
    }
}