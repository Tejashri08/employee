using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement
{
    public partial class TeamLeader : System.Web.UI.Page
    {
        public int EmployeeID { get; set; }
        public int ProjectID { get; set; }
       public string Name { get; set; }
         public string ProjectName { get; set; }
        public string Status { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {

            }
            else { }

            EmployeeID = int.Parse(Session["employeeid"].ToString());
            ClsEmployee obj= new ClsEmployee(EmployeeID);
            SqlDataReader dr;
            dr = obj.TLlogin();

            if (dr.Read())
            {
                lblTLName.Text = dr["Name"].ToString();
                ProjectName = dr["ProjectName"].ToString();
                ProjectID =int.Parse( dr["ProjectID"].ToString());
                Status = dr["Status"].ToString();
                lblProjectName.Text = ProjectName;
                lblPN1.Text = ProjectName;
                lblPN2.Text = ProjectName;
                lblPN3.Text = ProjectName;

              
                EmployeeID = int.Parse(dr["EmployeeID"].ToString());



            }
            if (Status == "Completed") 
            {
                btnActive1.Enabled= false;
                btnActive2.Enabled= false;  
                btnActive3.Enabled= false;
                btnActive1.Text = "Completed";
                btnActive2.Text = "Completed";
                btnActive3.Text = "Completed";
            }


        }

        protected void btnActive1_Click(object sender, EventArgs e)
        {
            btnActive2.Enabled = true;
            btnActive1.Text = "Completed";
        }

        protected void btnActive2_Click(object sender, EventArgs e)
        {
            btnActive3.Enabled = true;
            btnActive2.Text = "Completed";
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnActive3_Click(object sender, EventArgs e)
        {
            btnActive3.Text = "Completed";
            ClsEmployee update= new ClsEmployee(ProjectID);
            update.StatusUpdate();
        }
    }
}