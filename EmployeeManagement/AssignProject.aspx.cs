using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace EmployeeManagement
{
    public partial class AssignProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {

            }
            else
            {
                ClsEmployee clsEmployee = new ClsEmployee();
                DataTable dt = new DataTable();
                dt = clsEmployee.GetProject();
                drpProjectName.DataSource = dt;
                drpProjectName.DataTextField = "ProjectName";
                drpProjectName.DataValueField = "ProjectID";
                drpProjectName.DataBind();

                ClsEmployee obj = new ClsEmployee();
                DataTable dt1 = new DataTable();
                dt1 = obj.GetProjectMangerNames();
                drpProjectManager.DataSource = dt1;
                drpProjectManager.DataTextField = "Name";
                drpProjectManager.DataValueField = "EmployeeID";
                drpProjectManager.DataBind();

                ClsEmployee cls = new ClsEmployee();
                DataTable dt2 = new DataTable();
                dt2 = cls.UnassignProject();
                drpProjectName.DataSource = dt2;
                drpProjectName.DataTextField = "ProjectName";
                drpProjectName.DataValueField = "ProjectID";
                drpProjectName.DataBind();
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void btnAssign_Click(object sender, EventArgs e)
        {
            int ProjectID = int.Parse(drpProjectName.Text.ToString());
            int EmployeeID = int.Parse(drpProjectManager.Text.ToString());
            ClsEmployee project = new ClsEmployee(ProjectID, EmployeeID);
            project.AssignProject();
        }

        protected void drpProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}