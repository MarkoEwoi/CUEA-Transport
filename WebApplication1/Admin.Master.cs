using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDrivers_Click(object sender, EventArgs e)
        {
            //Redirects to the drivers web page
            Response.Redirect("~/Drivers.aspx");
        }

        protected void btnVehicles_Click(object sender, EventArgs e)
        {
            //Redirects to the vehicles web page
            Response.Redirect("~/Vehicles.aspx");
        }
    }
}