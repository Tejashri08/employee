using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeManagement
{
    public class ClsEmployee
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CM02ANM;Initial Catalog=EmployeeManagement;Integrated Security=True");
        public string Position { get; set; }
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public int StateID { get; set; }
        public string StateName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string Technology { get; set; }
        public string Status { get; set; }
        public string Amount { get; set; }
        public string Profilepath { get; set; }
        public int Pname { get; }
        public int Pmanager { get; private set; }

        public ClsEmployee(string position, string name,string email,string phone, string password, int cityID, string profilepath)
        { 
            Position=position;
            Name=name;
            Email=email;
            Phone=phone;
            Password=password;
            CityID = cityID;
            Profilepath=profilepath;
        }

        public ClsEmployee()
        {

        }

        public void EmployeeRegister()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "EmployeeRegister");
            cmd.Parameters.AddWithValue("@Position", Position);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@ProfilePhoto", Profilepath);
            cmd.Parameters.AddWithValue("@CityID", CityID);
           
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public ClsEmployee(int employeeID, int projectID,string amount)
        {
            EmployeeID=employeeID;
            ProjectID=projectID;
            Amount=amount;
        }
        public void PaymentDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "PaymentDetails");
            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteRecord()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteRecord");
            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable GetCountry()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCountry");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();


        }

        public ClsEmployee(int selectedID)
        {
            CountryID= selectedID;
            StateID= selectedID;
            CityID= selectedID;
            ProjectID = selectedID;
            EmployeeID = selectedID;
           
            
            
        }
        public DataTable GetState()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetState");
            cmd.Parameters.AddWithValue("CountryID", CountryID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();


        }

        public DataTable GetCity()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetCity");
            cmd.Parameters.AddWithValue("@StateID", StateID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();


        }

        public ClsEmployee(string projectname, string technology, string startDate, string endDate)
        {
            ProjectName= projectname;
            Technology= technology;
            StartDate=startDate;
            EndDate=endDate;
        }

        public void ProjectRegister()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ProjectRegister");
            cmd.Parameters.AddWithValue("@ProjectName", ProjectName);
            cmd.Parameters.AddWithValue("@Technology", Technology);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable AllProject()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adpt = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@Flag", "AllProject");
            adpt.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }

       
        public DataTable GetProject()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetProject");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();


        }

        public DataTable GetProjectMangerNames()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetProjectMangerNames");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();


        }

        public ClsEmployee(string position, string email, string password)
        {
            Position=position;
            Email=email;
            Password=password;  
        }
        public SqlDataReader Login()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Login");
            cmd.Parameters.AddWithValue("@Position", Position);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }


        public ClsEmployee(int projectID,int employeeID)
        {
           
            ProjectID = projectID;
            EmployeeID = employeeID;


        }
        public void AssignProject()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "AssignProject");
            cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable UnassignProject()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UnassignProject");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();


        }

        public DataTable GetPMAssignProjects()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetPMAssignProjects");
            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();


        }

        public DataTable GetTL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetTL");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();


        }
        public DataTable UnassignTL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UnassignTL");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();


        }
        public SqlDataReader TLlogin()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "TLlogin");
            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID); 
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public void StatusUpdate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "StatusUpdate");
            cmd.Parameters.AddWithValue("@ProjectID", ProjectID);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public DataTable CompletedProjects()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adpt = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@Flag", "CompletedProjects");
            adpt.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable AllPaymentDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adpt = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@Flag", "AllPaymentDetails");
            adpt.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable AllEmployee()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adpt = new SqlDataAdapter();
            cmd.Parameters.AddWithValue("@Flag", "AllEmployee");
            adpt.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }
        public SqlDataReader EmployeeDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "EmployeeDetails");
            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }

        public ClsEmployee( string name, string email, string phone, string password, int cityID, string profilepath)
        {
            
            Name = name;
            Email = email;
            Phone = phone;
            Password = password;
            CityID = cityID;
            Profilepath = profilepath;
        }
        public void UpdateDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("EmployeeManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateDetails");
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@CityID", CityID);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@ProfilePhoto", Profilepath);
            cmd.ExecuteNonQuery();

            con.Close();
        }

    }
}