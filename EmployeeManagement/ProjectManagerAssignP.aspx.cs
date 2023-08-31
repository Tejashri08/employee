using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement
{
    public partial class ProjectManagerAssignP : System.Web.UI.Page
    {
        public int EmployeeID { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

            }
            else
            {
                EmployeeID =int.Parse( Session["employeeid"].ToString());
                ClsEmployee manager = new ClsEmployee(EmployeeID);
                DataTable dt = new DataTable();
                dt = manager.GetPMAssignProjects();
                drpProjetcs.DataSource = dt;
                drpProjetcs.DataTextField = "ProjectName";
                drpProjetcs.DataValueField = "ProjectID";
                drpProjetcs.DataBind();


                ClsEmployee tl = new ClsEmployee();
                DataTable dt1 = new DataTable();
                dt1 = tl.GetTL();
                drpTeamLeader.DataSource = dt1;
                drpTeamLeader.DataTextField = "Name";
                drpTeamLeader.DataValueField = "EmployeeID";
                drpTeamLeader.DataBind();

                ClsEmployee untl = new ClsEmployee();
                DataTable dt2 = new DataTable();
                dt2 = untl.UnassignTL();
                drpTeamLeader.DataSource = dt2;
                drpTeamLeader.DataTextField = "Name";
                drpTeamLeader.DataValueField = "EmployeeID";
                drpTeamLeader.DataBind();
            }
        }

        protected void btnAssign_Click(object sender, EventArgs e)
        {
            int ProjectID = int.Parse(drpProjetcs.Text.ToString());
            int EmployeeID = int.Parse(drpTeamLeader.Text.ToString());
            ClsEmployee project = new ClsEmployee(ProjectID, EmployeeID);
            project.AssignProject();
        }
    }
    
}