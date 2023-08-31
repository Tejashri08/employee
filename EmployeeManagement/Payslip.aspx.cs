using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement
{
    public partial class Payslip : System.Web.UI.Page
    {
        public int ProjectID { get; set; }
        public int EmployeeID { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ProjectID = int.Parse(Request.QueryString["PID"]);
            EmployeeID = int.Parse(Request.QueryString["EmpID"]);

            if (IsPostBack)
            { }
            else 
            {
                Label7.Text = Request.QueryString["Pname"];
                Label8.Text = Request.QueryString["Tlname"];
                Label9.Text = Request.QueryString["phone"];
                Label10.Text = Request.QueryString["email"];
                Label11.Text = Request.QueryString["amount"];
                
                
            }

        }

        protected void btnPAY_Click(object sender, EventArgs e)
        {
            ClsEmployee pay=new ClsEmployee( EmployeeID,ProjectID, Label11.Text.ToString());
            pay.PaymentDetails();
            Response.Redirect("AllProjects.aspx");
        }
    }
}