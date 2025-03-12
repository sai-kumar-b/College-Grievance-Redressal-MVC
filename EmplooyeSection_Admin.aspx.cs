using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Grievance_Cell_Project
{
    public partial class EmplooyeSection_Admin : System.Web.UI.Page
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
            string query = "Select * from College_Employees";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtMobile.Text = txtID.Text = txtSalary.Text = txtName.Text = txtPassword.Text = "";
            GridView1.SelectedIndex = -1;
            lblErrorMsg0.Text = lblErrorMsg.Text = "";
            RadioButtonList1.SelectedIndex = -1;
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            lblErrorMsg0.Text = lblErrorMsg.Text = "";
                txtID.Text = string.Empty;
                lblErrorMsg0.Text = lblErrorMsg.Text = "";
                SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
                con.Open();
                string Department = DropDownList1.SelectedValue;
                string Designation = DropDownList2.SelectedValue;
             
                int Status = 1;
                if (RadioButtonList1.SelectedValue == "Active")
                {
                    Status = 1;
                }
                else
                {
                    Status = 0;
                }
                string query = "Insert into College_Employees values ('" + txtPassword.Text + "' , '" + txtName.Text + "' , '"+Designation+"' , '" + txtSalary.Text + "' , '" + Department + "' , '" + Status + "' , '" + txtMobile.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    txtMobile.Text = txtID.Text = txtSalary.Text = txtName.Text = txtPassword.Text = "";
                    GridView1.SelectedIndex = -1;
                    RadioButtonList1.SelectedIndex = -1;
                    Load();
                    string query2 = "Select max(emp_id) from College_Employees ";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    long Id = Convert.ToInt64(cmd2.ExecuteScalar());
                    lblErrorMsg.Text = "Details updated successfully..Your Roll Number is " + Id;
                }
                else
                {
                    lblErrorMsg.Text = "Failed...!";
                }
            con.Close();

        }

        protected void Updatebtn_Click(object sender, EventArgs e)
        {
            lblErrorMsg0.Text = lblErrorMsg.Text = "";
            SqlConnection con = new SqlConnection("data source =LAPTOP-VGA0UUB6\\NIT;database=sai;integrated security=yes");
            con.Open();
            string Department = DropDownList1.SelectedValue;
            string Designation = DropDownList2.SelectedValue;
            int Status;
       
            if (RadioButtonList1.SelectedValue == "Active")
            {
                Status = 1;
            }
            else
            {
                Status = 0;
            }
            string query = "update College_Employees set password='" + txtPassword.Text + "' , Name='" + txtName.Text + "' , Designation ='"+Designation+"' , Salary='" + txtSalary.Text + "' ,Department='" + Department + "', Mobile_No='" + txtMobile.Text + "' , Status='" + Status + "'  where Emp_Id='" + txtID.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                lblErrorMsg.Text = "Details updated successfully...!";
                txtMobile.Text = txtID.Text = txtSalary.Text = txtName.Text = txtPassword.Text = "";
                GridView1.SelectedIndex = -1;
                RadioButtonList1.SelectedIndex = -1;
                Load();
            }
            else
            {
                lblErrorMsg.Text = "Failed...!";
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session["Emp_id"] = null;
            Response.Redirect("HomePage.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            txtID.Text = row.Cells[1].Text;
            txtPassword.Text = row.Cells[2].Text;
            txtName.Text = row.Cells[3].Text;
            DropDownList2.SelectedItem.Text= row.Cells[4].Text; 
            txtSalary.Text = row.Cells[5].Text;
            DropDownList1.SelectedItem.Text = row.Cells[6].Text;
            //txtDeparment.Text = row.Cells[5].Text;
            txtMobile.Text = row.Cells[8].Text;
            if ((row.Cells[7].Text) != null)
            {
                RadioButtonList1.SelectedValue = "Active";
            }
     
        }
    }
}