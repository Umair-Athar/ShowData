using ShowData.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Web;

namespace ShowData.Repository
{
    public class Mn_Info_Repository
    {
        private SqlConnection con;
        //To Handle connection related activities
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["DbConnection"].ToString();
            con = new SqlConnection(constr);

        }
        //To view employee details with generic list 
        public List<Models.Get_Mn_Info_Result> Get_MnInfo(int? id)
        {
            connection();
            List<Get_Mn_Info_Result> EmpList = new List<Get_Mn_Info_Result>();
            SqlCommand com = new SqlCommand("Get_Mn_Info", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@tx_id", id);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            //Bind EmpModel generic list using LINQ 
            EmpList = (from DataRow dr in dt.Rows

                       select new Get_Mn_Info_Result()
                       {
                           username = Convert.ToString(dr["username"]),
                           consumedshares = Convert.ToInt32(dr["consumedshares"]),
                           remaining = Convert.ToInt32(dr["remaining"]),
                           packof = Convert.ToInt32(dr["packof"]),
                           label = Convert.ToString(dr["label"]),
                           shareadded = Convert.ToInt32(dr["shareadded"])

                       }).ToList();


            return EmpList;


        }
    }
}