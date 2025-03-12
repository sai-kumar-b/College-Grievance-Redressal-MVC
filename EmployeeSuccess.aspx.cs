using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Grievance_Cell_Project
{
    public partial class EmployeeSuccess : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Emp_id"] != null)
                {
                if (!IsPostBack)
                {
                    SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
                    con.Open();
                    string Department = Session["Department"].ToString();
                    string status = "-Pending-";
                    string query = "Select * from College_Complaintss where type='" + Department + "' and Status='" + status + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DropDownList1.Items.Add(dr["Complaint_id"].ToString());
                    }
                    con.Close();
                }
                }
                else
                {
                    Response.Redirect("HomePage.aspx");
                }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string p = DropDownList1.SelectedValue.ToString();  
            id = int.Parse(DropDownList1.SelectedItem.ToString());
            if (id > 0)
            {
                SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
                con.Open();
                string query = "Select * from College_Complaintss where Complaint_id='" + id + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox1.Text = dr["Complaint"].ToString();
                    TextBox2.Text = dr["Raised_On"].ToString();
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e) //update button
        {
           
                id = int.Parse(DropDownList1.SelectedValue.ToString());
                if (id > 0)
                {
                    SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
                    string Status = "Solved";
                    DateTime aDate = DateTime.Now;
                    string date = aDate.ToString("yyyy/MM/dd");
                    con.Open();
                    string query = "update College_Complaintss set Status ='" + Status + "' ,Solved_On='" + date + "' where Complaint_id='" + id + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        TextBox1.Text = TextBox2.Text = "";
                        DropDownList1.Items.Remove(id.ToString());
                        lblError.Text = "Compliant Solved Successfully ";
                        CmptStatus("Solved");
                    }
                    else
                    {
                        lblError.Text = "No complaints found or error in executing";
                    }
                }
            }
          
        

        protected void btnSolved_Click(object sender, EventArgs e)
        {
            CmptStatus("Solved");
        }
        public void CmptStatus(string Status)
        {
            lblMsg.Text = "";
            SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
            con.Open();
            string type = "";
            if (Status == "Solved")
            {
                type = "Solved_On";
            }
            else if(Status =="-Pending-")
            {
               type = "Raised_On";
            }
            string query = "Select * from College_Complaintss where type='" + Session["Department"] + "' and Status='" + Status + "' order by "+type+" asc";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
            if (GridView1.Rows.Count <= 0)
            {
                lblMsg.Text = "no pending complaints found";
            }
        }
        protected void btnPending_Click(object sender, EventArgs e)
        {
            CmptStatus("-Pending-");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session["Emp_id"]= null;
            //Session.Abandon();
            Response.Redirect("HomePage.aspx");
        }
    }
}