using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement
{
    public partial class Projects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {

            }
            else
            {

               int EmployeeID = int.Parse(Session["employeeid"].ToString());
                ClsEmployee obj = new ClsEmployee(EmployeeID);
                DataTable dt = new DataTable();
                dt = obj.GetPMAssignProjects();
                grdprojects.DataSource = dt;
                grdprojects.DataBind();
            }

        }

        protected void grdprojects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}