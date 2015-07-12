using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementsystem.DAL.DAO;

namespace FairManagementsystem.DAL.Gateway
{
    class ZoneTypeGateway
    {
        DBGateway dbGateway=new DBGateway();

        public int Save(ZoneType aZoneType)
        {

            dbGateway.SqlCommandObj.CommandText = "INSERT INTO ZoneType_tbl VALUES('" + aZoneType.Zonetype + "')";
             
            dbGateway.SqlConnectionObj.Open();
            int rowAffected = dbGateway.SqlCommandObj.ExecuteNonQuery();
            dbGateway.SqlConnectionObj.Close();
            return rowAffected;
        }


        public List<ZoneType> GetAllZone()
        {
            dbGateway.SqlCommandObj.CommandText = "SELECT * FROM ZoneType_tbl";
            dbGateway.SqlConnectionObj.Open();
            SqlDataReader reader = dbGateway.SqlCommandObj.ExecuteReader();
            List<ZoneType> zoneTypeList=new List<ZoneType>();   

            if (reader != null)
                while (reader.Read())
                {
                    ZoneType zoneType = new ZoneType();
                    zoneType.ID = Convert.ToInt16(reader["ID"].ToString());
                    zoneType.Zonetype = reader["ZoneType"].ToString();
                    zoneTypeList.Add(zoneType);

                }
            reader.Close();
            dbGateway.SqlConnectionObj.Close();
            return zoneTypeList;

        }
        public int GetZoneID(string zoneName)
        {
            dbGateway.SqlCommandObj.CommandText = "SELECT * FROM ZoneType_tbl WHERE ZoneType='"+zoneName+"'";
            dbGateway.SqlConnectionObj.Open();
            SqlDataReader reader = dbGateway.SqlCommandObj.ExecuteReader();
            int zoneID = 0;

            if (reader != null)
                while (reader.Read())
                {
                    zoneID = int.Parse(reader[0].ToString());
                    break;

                }
            reader.Close();
            dbGateway.SqlConnectionObj.Close();
            return zoneID;

        }
         
        

        
    }
}
