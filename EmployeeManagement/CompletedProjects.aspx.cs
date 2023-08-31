using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement
{
    public partial class CompletedProjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) { }
            else
            {
                ClsEmployee cmp = new ClsEmployee();
                DataTable dt = new DataTable();
                dt = cmp.CompletedProjects();
                grdcompleteprojects.DataSource = dt;
                grdcompleteprojects.DataBind();
            }

        }

        protected void grdcompleteprojects_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ProjectName = grdcompleteprojects.SelectedRow.Cells[2].Text;
            int ProjectID = int.Parse(grdcompleteprojects.SelectedRow.Cells[1].Text.ToString());
            int EmployeeID = int.Parse(grdcompleteprojects.SelectedRow.Cells[11].Text.ToString());
            string TLName= grdcompleteprojects.SelectedRow.Cells[13].Text;
            string Phone= grdcompleteprojects.SelectedRow.Cells[15].Text;
            string Email= grdcompleteprojects.SelectedRow.Cells[14].Text;
            string Amount = "60000";
            Response.Redirect("Payslip.aspx?Pname="+ ProjectName+"&PID="+ProjectID+"&EmpID="+EmployeeID+"&Tlname="+ TLName+"&phone="+ Phone+"&email="+ Email+"&amount="+ Amount);
        }
        
    }
}