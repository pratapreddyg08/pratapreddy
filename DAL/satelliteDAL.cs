using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class satelliteDAL
    {
        private SqlConnection _SqlCon;
        public satelliteDAL()
        {
            _SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
        }
        public void insertdata(int Id, string Place, int StationCode)
        {
            _SqlCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("Insert into satellitedata values('" + Id + "','" + Place + "','" + StationCode + "')", _SqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _SqlCon.Close();
        }
        public object selectdata()
        {
            _SqlCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from satellitedata", _SqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _SqlCon.Close();
            return dt;
        }
        public void updatedata( string Place, int StationCode, int Id)
        {
            _SqlCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("Update satellitedata set id='"+Id+"',Place='"+Place+"'where Id='"+Id+"'", _SqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _SqlCon.Close();
        }
        public void deletedata(int Id)
        {
            _SqlCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("Delete from satellitedata where Id='"+Id+"'", _SqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _SqlCon.Close();
        }
    }
}
