using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace EmployeeManagement
{
    public partial class Login : System.Web.UI.Page
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int EmployeeID { get; set; }

        private string Position { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            drpPosition.Items.Add("Team Leader");
            drpPosition.Items.Add("Project Manager");
            drpPosition.Items.Add("Admin");

            if (IsPostBack)
            {

            }
            else { }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ClsEmployee Login1 = new ClsEmployee(drpPosition.Text ,txtEmail.Text, txtPassword.Text);
            SqlDataReader dr;
            dr = Login1.Login();

            if (dr.Read())
            {
                Email = dr["Email"].ToString();
                Password = dr["Password"].ToString();
                Position = dr["Position"].ToString();
                EmployeeID =int.Parse( dr["EmployeeID"].ToString());



            }

            if (txtEmail.Text == Email && txtPassword.Text == Password && drpPosition.Text == "Admin")
            {
                Response.Redirect("AllProjects.aspx");
            }
            else if (txtEmail.Text == Email && txtPassword.Text == Password && drpPosition.Text == "Project Manager")
            {
                Session["employeeid"] = EmployeeID;
                Response.Redirect("ProjectManagerAssignP.aspx");
            }

            else if (txtEmail.Text == Email && txtPassword.Text == Password && drpPosition.Text == "Team Leader")
            {
                Session["employeeid"] = EmployeeID;
                Response.Redirect("TeamLeader.aspx");
            }



        }
    }
}