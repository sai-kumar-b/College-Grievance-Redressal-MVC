using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Grievance_Cell_Project
{
    public partial class StudentLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Focus();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
            con.Open();
            string query = "select * from College_Students where Roll_Number=" + TextBox1.Text;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr["Password"].ToString() == TextBox2.Text)
                {
                    Session["Roll_Number"] = dr["Roll_Number"].ToString();
                    Session["Department"] = dr["Department"].ToString();
                    Session["Password"] = dr["Password"].ToString();
                    Session["Name"] = dr["Name"].ToString();
                    Session["Mobile_No"] = dr["Mobile_No"].ToString();
                    Session["Year"] = dr["Year"].ToString();
                    dr.Close();
                    Response.Redirect("RaiseCompliant.aspx");
                    //lblErrorMsg.Text = "Success";
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    lblErrorMsg.Text = "Invalid Credentions";
                }
            }
            else
            {
                lblErrorMsg.Text = "Invalid Credentions";
            }
            con.Close();
        }
    }
}