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
    public partial class SearchMember : System.Web.UI.Page
    {
        private string firstName;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           firstName = TextBox1.Text;

            ManagerMember manMemb = new ManagerMember();
            List<Member> mylist = manMemb.SearchByFirstName(firstName).ToList<Member>();

            Session["ObjectParameterName"] = mylist[0].FirstName;
            ObjectDataSource1.Select();
           // System.Diagnostics.Process.Start("http://localhost:61215/MembersPage.aspx");
        }
    }
}