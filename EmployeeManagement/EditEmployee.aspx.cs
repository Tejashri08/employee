using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement
{
    public partial class EditEmployee : System.Web.UI.Page
    {
        public int EmployeeID { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

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

                EmployeeID=int.Parse( Session["employeeid"].ToString());
                ClsEmployee edit= new ClsEmployee(EmployeeID);
                SqlDataReader reader = edit.EmployeeDetails();
                while(reader.Read())
                {
                    txtName.Text= reader["Name"].ToString();
                    txtEmail.Text= reader["Email"].ToString();
                    txtPhone.Text= reader["Phone"].ToString();
                    txtPassword.Text= reader["Password"].ToString();
                    string url= reader["ProfilePhoto"].ToString() ;
                    imgProfile.ImageUrl ="~/"+ url;
                }


            }

        }

        
    protected void btnRegister_Click(object sender, EventArgs e)
        {
            
        }

        protected void drpContury_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsEmployee cls = new ClsEmployee(int.Parse(drpContury.SelectedValue.ToString()));
            DataTable dt = new DataTable();
            dt = cls.GetState();
            drpState.DataSource = dt;
            drpState.DataTextField = "StateName";
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
        public string Profilepath { get; set; }
        protected void btnViewImage_Click(object sender, EventArgs e)
        {

            if (FileUploadProfile.HasFile)
            {
                FileUploadProfile.SaveAs(Server.MapPath("~/profileimage/") + System.IO.Path.GetFileName(FileUploadProfile.FileName));
                 Profilepath = "~/profileimage/" + System.IO.Path.GetFileName(FileUploadProfile.FileName);
                imgProfile.ImageUrl = "~/" + Profilepath;
                lbldemo.Text= "~/profileimage/" + System.IO.Path.GetFileName(FileUploadProfile.FileName);


            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (FileUploadProfile.HasFile)
            {
                FileUploadProfile.SaveAs(Server.MapPath("~/profileimage/") + System.IO.Path.GetFileName(FileUploadProfile.FileName));
                string Profilepath = "profileimage/" + System.IO.Path.GetFileName(FileUploadProfile.FileName);
                ClsEmployee employee = new ClsEmployee( txtName.Text, txtEmail.Text, txtPhone.Text,
                    txtPassword.Text, Convert.ToInt32(drpContury.SelectedValue.ToString()), Profilepath);
                employee.UpdateDetails();
            }
        }
    }
}