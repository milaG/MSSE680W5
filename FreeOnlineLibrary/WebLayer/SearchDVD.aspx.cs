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
    public partial class SearchDVD : System.Web.UI.Page
    {
        private string title;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            title = TextBox1.Text;

            ManagerDVD manDVD = new ManagerDVD();
            List<DVD> mylist = manDVD.SearchByTitle(title).ToList<DVD>();

            Session["ObjectParameterName"] = mylist[0].DvdTitle;
            ObjectDataSource1.Select();
        }
    }
}