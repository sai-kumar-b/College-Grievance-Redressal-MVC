using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Grievance_Cell_Project
{
    public partial class UpdateStudent : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Roll_Number"] != null)
                {
                    con.Close();
                    txtRollNumber.Text = Session["Roll_Number"].ToString();
                    temp();
                    txtDepartment.Text = Session["Department"].ToString();
                } 
                else
                {
                    Response.Redirect("StudentLogin.aspx");
                }
            }
        }
        public void temp()
        {
            con.Close ();
            con.Open();
            string query = "select * from College_Students where Roll_Number='" + txtRollNumber.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtName.Text = dr["Name"].ToString();
                txtPassword.Text = dr["Password"].ToString();
                txtMobileNo.Text = dr["Mobile_No"].ToString();
                txtYear.Text = dr["Year"].ToString();
            }
            con.Close();
        }
        public void data()
        {
            con.Close();
            con.Open();
            string query = "select * from College_Students where Roll_Number='"+txtRollNumber.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtName.Text = dr["Name"].ToString();
                txtPassword.Text = dr["Password"].ToString();
                txtMobileNo.Text = dr["Mobile_No"].ToString();
                txtYear.Text = dr["Year"].ToString();
            }
            con.Close();
            
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update College_Students set password='"+txtPassword.Text+"' , Name='"+txtName.Text+"' , Year="+txtYear.Text+" , Mobile_No='"+txtMobileNo.Text+"'  where Roll_Number='"+txtRollNumber.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            if(cmd.ExecuteNonQuery()>0)
            {
                lblMsg.Text = "Details updated successfully...!";
                data();            
            }
            con.Close();
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session["Roll_Number"] = null;
            Response.Redirect("StudentLogin.aspx");
        }
    }
}