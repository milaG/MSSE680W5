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
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Book bb = new Book();
            bb.BookTitle = TextBox1.Text;
            bb.Author = TextBox2.Text;
            bb.Summary = TextBox3.Text;
            bb.BookDownload = TextBox4.Text;

            ManagerBook manBook = new ManagerBook();
            manBook.InsertBook(bb); 
            System.Web.UI.ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('" + "The book has been added" + "')", true);
 
        }
    }
}