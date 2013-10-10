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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Member memb = new Member();
            memb.FirstName = TextBox1.Text;
            memb.LastName =  TextBox2.Text;
            memb.Username =  TextBox3.Text;
            memb.Password =  TextBox4.Text;

            ManagerMember manMemb = new ManagerMember();
            manMemb.InsertMember(memb);
            System.Web.UI.ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('" +"You have been added" + "')", true);
        }
    }
}