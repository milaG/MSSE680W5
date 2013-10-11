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
    public partial class AddDvd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DVD dvd = new DVD();
            dvd.DvdTitle = TextBox1.Text;
            dvd.DvdRating = TextBox2.Text;

            ManagerDVD manDvd = new ManagerDVD();
            manDvd.InsertDVD(dvd);
            System.Web.UI.ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "alert('" + "The DVD has been added" + "')", true);
 
        }
    }
}