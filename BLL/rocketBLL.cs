using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class rocketBLL
    {
    }
    
    public class clsBussLayer
    {
        rocketDAL objDAL = new rocketDAL();


        public void InsertRocket(int Id,string Name,string VehicleType,string Purpose)
        {
            objDAL.InsertRocket(Id,Name,VehicleType,Purpose); 
            
        }
        public object SelectRocket()
        {
            return objDAL.SelectRocket();
        }
        public void UpdateRocket( string Name, string VehicleType, string Purpose, int Id)
        {
            objDAL.UpdateRocket( Name, VehicleType,Purpose, Id);
        }
        public void DeleteRocket(int Id)
        {
             objDAL.DeleteRocket(Id);
        }
    }
}
