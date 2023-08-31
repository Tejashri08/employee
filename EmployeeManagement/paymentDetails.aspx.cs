using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement
{
    public partial class paymentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) 
            { 

            }
            else
            {
                ClsEmployee p = new ClsEmployee();
                DataTable dt = new DataTable();
                dt = p.AllPaymentDetails();
                grdPaymentdetails.DataSource = dt;
                grdPaymentdetails.DataBind();
            }

        }

        protected void grdPaymentdetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            int EmployeeID = int.Parse(grdPaymentdetails.SelectedRow.Cells[6].Text.ToString());
            ClsEmployee obj = new ClsEmployee(EmployeeID);
            obj.DeleteRecord();
            Response.Redirect("paymentDetails.aspx");

        }
    }
}