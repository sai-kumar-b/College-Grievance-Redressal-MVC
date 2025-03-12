using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Grievance_Cell_Project
{
    public partial class AdminSuccess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         if (Session["Emp_id"] == null)
            {
                Response.Redirect("HomePage.aspx");
            }

        }
    }
}