using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace EmployeeManagement
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            drpPosition.Items.Add("Team Leader");
            drpPosition.Items.Add("Project Manager");
            drpPosition.Items.Add("Admin");

            if (IsPostBack)
            { 

            }
            else
            {
                ClsEmployee clsEmployee = new ClsEmployee();
                DataTable dt = new DataTable();
                dt = clsEmployee.GetCountry();
                drpContury.DataSource = dt;
                drpContury.DataTextField = "CountryName";
                drpContury.DataValueField = "CountryID";
                drpContury.DataBind();
            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (FileUploadProfile.HasFile)
            {
                FileUploadProfile.SaveAs(Server.MapPath("~/profileimage/")+System.IO.Path.GetFileName(FileUploadProfile.FileName));
                string Profilepath = "profileimage/" + System.IO.Path.GetFileName(FileUploadProfile.FileName);
                ClsEmployee employee = new ClsEmployee(drpPosition.Text, txtName.Text, txtEmail.Text, txtPhone.Text,
                    txtPassword.Text, Convert.ToInt32(drpCity.SelectedValue.ToString()), Profilepath);
                employee.EmployeeRegister();
            }        
        }

        protected void drpContury_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsEmployee cls=new ClsEmployee(int.Parse(drpContury.SelectedValue.ToString()));
            DataTable dt = new DataTable();
            dt = cls.GetState();
            drpState.DataSource = dt;
            drpState.DataTextField= "StateName";
            drpState.DataValueField = "StateID";
            drpState.DataBind();
        }

        protected void drpState_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsEmployee cls = new ClsEmployee(int.Parse(drpState.SelectedValue.ToString()));
            DataTable dt = new DataTable();
            dt = cls.GetCity();
            drpCity.DataSource = dt;
            drpCity.DataTextField = "CityName";
            drpCity.DataValueField = "CityID";
            drpCity.DataBind();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            //drpPosition.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
           // drpContury.Text = "";
           // drpState.Text = "";
            //drpCity.Text = "";
            txtPassword.Text = "";
        }

        protected void drpCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}