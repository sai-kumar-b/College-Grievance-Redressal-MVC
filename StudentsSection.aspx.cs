using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;

namespace Grievance_Cell_Project
{
    public partial class StudentsSection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                    if (Session["Emp_id"] != null)
                    {
                        Load();
                    }
                    else
                    {
                        Response.Redirect("HomePage.aspx");
                    }
                
            }
        }
        public void Load()
        {
            SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
            con.Open();
            string query = "Select * from College_Students ";
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
            txtRollNumber.Text = row.Cells[1].Text;
            txtPassword.Text = row.Cells[2].Text;
            txtName.Text = row.Cells[3].Text;
            txtYear.Text = row.Cells[4].Text; 
            DropDownList1.SelectedItem.Text= row.Cells[5].Text;    
            //txtDeparment.Text = row.Cells[5].Text;
            txtMobile.Text = row.Cells[6].Text; 
            if ((row.Cells[7].Text)!=null)
            {
                RadioButtonList1.SelectedValue = "Active";
            }
           
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
                lblErrorMsg0.Text = lblErrorMsg.Text = "";
                SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
                con.Open();
                string Department = DropDownList1.SelectedValue;
                int Status;
                if (RadioButtonList1.SelectedValue == "Active")
                {
                    Status = 1;
                }
                else
                {
                    Status = 0;
                }
                string query = "update College_Students set password='" + txtPassword.Text + "' , Name='" + txtName.Text + "' , Year=" + txtYear.Text + " ,Department='" + Department + "', Mobile_No='" + txtMobile.Text + "' , Status='" + Status + "'  where Roll_Number='" + txtRollNumber.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    lblErrorMsg.Text = "Details updated successfully...!";
                    txtMobile.Text = txtRollNumber.Text = txtYear.Text = txtName.Text = txtPassword.Text = "";
                    GridView1.SelectedIndex = -1;
                    RadioButtonList1.SelectedIndex = -1;
                    Load();
                }
                else
                {
                    lblErrorMsg.Text = "Failed...!";
                }
        }

        protected void Insertbtn_Click(object sender, EventArgs e)
        {
            lblErrorMsg0.Text = lblErrorMsg.Text = "";
            //if (txtRollNumber.Text == null)
            //{
                lblErrorMsg0.Text = lblErrorMsg.Text = "";
                SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
                con.Open();
                string Department = DropDownList1.SelectedValue;
                int Status = 1;
                if (RadioButtonList1.SelectedValue == "Active")
                {
                    Status = 1;
                }
                else
                {
                    Status = 0;
                }
                string query = "Insert into College_Students values ('" + txtPassword.Text + "' , '" + txtName.Text + "' , " + txtYear.Text + " , '" + Department + "' , '" + txtMobile.Text + "' , '" + Status + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    txtMobile.Text = txtRollNumber.Text = txtYear.Text = txtName.Text = txtPassword.Text = "";
                    GridView1.SelectedIndex = -1;
                    RadioButtonList1.SelectedIndex = -1;
                    Load();
                    string query2 = "Select max(Roll_Number) from College_Students ";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    long Id = Convert.ToInt64(cmd2.ExecuteScalar());
                    lblErrorMsg.Text = "Admission successful..Your Roll Number is " + Id;
                }
                else
                {
                    lblErrorMsg.Text = "Failed...!";
                }
                con.Close();
            //}
            //else
            //{
            //    lblErrorMsg0.Text = "Failed to insert Roll Number should be empty";
            //}

        }

        protected void Resetbtn_Click(object sender, EventArgs e)
        {
            txtMobile.Text = txtRollNumber.Text = txtYear.Text = txtName.Text = txtPassword.Text = "";
            GridView1.SelectedIndex = -1;
            lblErrorMsg0.Text = lblErrorMsg.Text = "";
            RadioButtonList1.SelectedIndex = -1;
        }

        protected void LogOutbtn_Click(object sender, EventArgs e)
        {
            Session["Emp_id"] = null;
            Session.Abandon();  
            Response.Redirect("AdminLogin.aspx");
        }

        //protected void btnDelete_Click(object sender, EventArgs e)
        //{
        //    lblErrorMsg0.Text = lblErrorMsg.Text = "";
        //    SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
        //    con.Open();
        //    string query = "delete from College_Students  where Roll_Number='" + txtRollNumber.Text + "'";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    if (cmd.ExecuteNonQuery() > 0)
        //    {
        //        lblErrorMsg.Text = "Student Details Deleted ...!";
        //        txtMobile.Text = txtRollNumber.Text = txtYear.Text = txtName.Text = txtPassword.Text = "";
        //        GridView1.SelectedIndex = -1;
        //        RadioButtonList1.SelectedIndex = -1;
        //        Load();
        //    }
        //    else
        //    {
        //        lblErrorMsg.Text = "Failed...!";
        //    }
        //}
    }
}