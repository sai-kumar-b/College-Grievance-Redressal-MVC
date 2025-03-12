using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Grievance_Cell_Project
{
    public partial class HODLogin : System.Web.UI.Page
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
            string Designation = "Admin";
            string query = "select * from College_Employees where Emp_id=" + TextBox1.Text + " and Designation!='" + Designation + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                if (dr["Password"].ToString() == TextBox2.Text)
                {
                    Session["Department"] = dr["Department"].ToString();
                    Session["Emp_id"] = dr["Emp_id"].ToString();
                    dr.Close();
                    Response.Redirect("EmployeeSuccess.aspx");
                    //lblErrorMsg.Text = "Success";
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
