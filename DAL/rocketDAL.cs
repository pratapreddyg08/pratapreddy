using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
   
    public class rocketDAL
    {
        private SqlConnection _SqlCon;
        public rocketDAL()
        {
             _SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
        }
       
        public void InsertRocket(int Id, string Name, string VehicleType, string Purpose)
        {
            _SqlCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("Insert into rocketdata values('"+Id+"','"+Name+"','"+VehicleType+"','"+Purpose+"')",_SqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _SqlCon.Close();
        }
        public object SelectRocket()
        {
            _SqlCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from rocketdata", _SqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _SqlCon.Close();
            return dt;
        }
        public void UpdateRocket(string Name, string VehicleType, string Purpose,int Id)
        {
            _SqlCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("UPDATE rocketdata SET Name='" + Name + "',VehicleType='" + VehicleType + "',Purpose='" + Purpose + "'  WHERE  Id='" + Id + "'", _SqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _SqlCon.Close();
             
        }
        public void DeleteRocket(int Id)
        {
            _SqlCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("DELETE FROM rocketdata WHERE Id='"+ Id +"'", _SqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _SqlCon.Close();
        }
    }
}
