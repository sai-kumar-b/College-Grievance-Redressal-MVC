using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Grievance_Cell_Project
{
    public partial class CompliantsSection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["Emp_id"] != null)
                {
                  CmptStatus("-Pending-");
                }
                else
                {
                    Response.Redirect("HomePage.aspx");
                }
            
        }
        public void CmptStatus(string Status)
        {
            SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
            con.Open();
            string type = "";
            if (Status == "Solved")
            {
                type = "Solved_On";
            }
            else if (Status == "-Pending-")
            {
                type = "Raised_On";
            }
            string query = "Select * from College_Complaintss where Status='"+Status +"' order by " + type + " asc";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            txtId.Text = row.Cells[2].Text;
            txtType.Text = row.Cells[3].Text;
            txtAbout.Text = row.Cells[4].Text;
            txtDate.Text = row.Cells[5].Text;
        }

        protected void btnSolved_Click(object sender, EventArgs e)
        {
            CmptStatus("Solved");
        }

        protected void btnPending_Click(object sender, EventArgs e)
        {
            CmptStatus("-Pending-");
        }

        protected void btnSolve_Click(object sender, EventArgs e)
        {
            string Status = "Solved";
            SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
            con.Open();
            DateTime aDate = DateTime.Now;
            string date = aDate.ToString("yyyy/MM/dd");
            string query = "Update College_Complaintss set Status='"+ Status+ "' , Solved_On ='"+date+"'  where Complaint_id='" + txtId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                lblMsg.Text = "Compliant solved successfully...!";
                txtId.Text = txtDate.Text = txtAbout.Text = txtId.Text = "";
                GridView1.SelectedIndex = -1;
                CmptStatus("Solved");
            }
            else
            {
                lblMsg.Text = "Failed...!";
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session["Emp_id"] = null;
            Session.Abandon();  
            Response.Redirect("AdminLogin.aspx");
        }
    }
}