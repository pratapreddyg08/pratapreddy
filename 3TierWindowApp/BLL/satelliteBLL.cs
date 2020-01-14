using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class satelliteBLL
    {
        satelliteDAL objSDAL = new satelliteDAL();

        public void insertdata(int Id, string Place, int StationCode)
        {
             objSDAL.insertdata(Id, Place, StationCode);

        }
        public object selectdata()
        {
             return objSDAL.selectdata();

        }
        public void updatedata(string Place, int StationCode, int Id)
        {
            objSDAL.updatedata(Place, StationCode, Id);

        }
        public void deletedata(int Id)
        {
            objSDAL.deletedata(Id);
        }
    }
}
