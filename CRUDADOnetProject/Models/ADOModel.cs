using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Web;

namespace CRUDADOnetProject.Models
{
    public class ADOModel
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Passward { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        public string  SaveEmployee(ADOModel model)
        {
            string msg = "submit";
            string objConn = ConfigurationManager.ConnectionStrings["ADO2"].ToString();
            SqlConnection Conn = new SqlConnection(objConn);
            SqlCommand cmd = new SqlCommand("sp_EmpSave", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", model.EmpId);
            cmd.Parameters.AddWithValue("Name", model.Name);
            cmd.Parameters.AddWithValue("Email", model.Email);
            cmd.Parameters.AddWithValue("Passward", model.Passward);
            cmd.Parameters.AddWithValue("Address", model.Address);
            cmd.Parameters.AddWithValue("State", model.State);
            cmd.Parameters.AddWithValue("City", model.City);

            Conn.Open();
             cmd.ExecuteNonQuery();
            Conn.Close();
           
                return msg;
            

        }

        //public List<ADOModel> GetList() { 
        //    List<ADOModel> adolist = new List<ADOModel>();
        //    ConfigurationManager.ConnectionStrings["ADO2"].ConnectionString;
        //    SqlConnection sqlConn = new SqlConnection();
        //    sqlConn = new SqlConnection(objConn);
        //    SqlCommand cm = sqlConn.CreateCommand();
        //    cm.CommandText = "Sp_Join";
        //    cm.CommandType = CommandType.StoredProcedure;

        //}

    }
}