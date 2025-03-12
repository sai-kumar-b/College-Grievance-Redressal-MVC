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
    public partial class RaiseCompliant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["Roll_Number"] != null)
                {
                    TextBox2.Text = Session["Roll_Number"].ToString();
                }
                else
                {
                    Response.Redirect("HomePage.aspx");
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string query;
            SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
            con.Open();
            string solve = " ";
            string raised = "-Pending-";
            string dpmrt = Session["Department"].ToString();
            if (DropDownList1.SelectedItem.ToString() =="Department")
            {
                query = $"insert into College_Complaintss values({TextBox2.Text},'{dpmrt}','{TextBox1.Text}','{DateTime.Now.ToString("yyyy-MM-dd")}','{raised}','{solve}')";
            }
            else
            {
                query = $"insert into College_Complaintss values({TextBox2.Text},'{DropDownList1.SelectedItem.ToString()}','{TextBox1.Text}','{DateTime.Now.ToString("yyyy-MM-dd")}','{raised}','{solve}')";
            }
            SqlCommand cmd = new SqlCommand(query, con);
            if(cmd.ExecuteNonQuery()>0)
            {
                string query2 = "select max(complaint_id) from College_Complaintss where Student_id=" + TextBox2.Text;
                SqlCommand cmd2 = new SqlCommand(query2, con);
                int id =Convert.ToInt32(cmd2.ExecuteScalar());
                lblMsg.Text = "Complaint raised successfully..! Your complaint id is " + id;
            }
            else
            {
                Response.Write("failed");
            }
            con.Close();
        }

        public void Status(string Status)
        {
            lblMsg.Text = "";
            SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
            con.Open();
            string type = "";
            if (Status == "Solved")
            {
                type = "Solved_On";
            }
            else
            {
                type = "Raised_On";
            }
            string query = "Select * from College_Complaintss where Student_id=" + Session["Roll_Number"].ToString() + " and Status='" + Status +"' order by " + type + " desc";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
            if (GridView1.Rows.Count <= 0)
            {
                if(Status=="-Pending-")
                lblMsg.Text = "no pending complaints found";
                else
                {
                    lblMsg.Text = "no Solved complaints found";
                }
            }

        }
        protected void btnPending_Click(object sender, EventArgs e)
        {
            Status("-Pending-");
        }

        protected void btnSolved_Click(object sender, EventArgs e)
        {
            Status("Solved");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateStudent.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session["Roll_Number"] = null;
            Session.Abandon();
            Response.Redirect("StudentLogin.aspx");
        }
    }
}