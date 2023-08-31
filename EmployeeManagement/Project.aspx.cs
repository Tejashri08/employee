using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement
{
    public partial class Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            drpTechnology.Items.Add("C#");
            drpTechnology.Items.Add("ADO.net");
            drpTechnology.Items.Add("Asp.net");
            drpTechnology.Items.Add("Mvc");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void drpTechnology_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            ClsEmployee obj =new ClsEmployee(txtProjectName.Text,drpTechnology.Text,txtStartDate.Text,txtEndDate.Text);
            obj.ProjectRegister();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtProjectName.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
        }
    }
}