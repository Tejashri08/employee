using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement
{
    public partial class AllEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

            }
            else
            {

                ClsEmployee employee = new ClsEmployee();
                DataTable dt = new DataTable();
                dt = employee.AllEmployee();
                grdAllEmployee.DataSource = dt;
                grdAllEmployee.DataBind();
            }

        }

        protected void grdAllEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["EmployeeID"] = int.Parse(grdAllEmployee.SelectedRow.Cells[1].Text.ToString());
            Response.Redirect("EditEmployee.aspx");
        }
    }
}