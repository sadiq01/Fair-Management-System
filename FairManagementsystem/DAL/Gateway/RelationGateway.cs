using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementsystem.DAL.DAO;

namespace FairManagementsystem.DAL.Gateway
{
    class RelationGateway
    {

        DBGateway dbGateway = new DBGateway();
        ZoneTypeGateway zoneGateway = new ZoneTypeGateway();

        public void SaveRelation(int visitorID, int zoneID)
        {
            dbGateway.SqlCommandObj.CommandText = "INSERT INTO Relation_tbl VALUES('" + visitorID + "','" + zoneID +
                                                  "')";
            dbGateway.SqlConnectionObj.Open();
            dbGateway.SqlCommandObj.ExecuteNonQuery();
            dbGateway.SqlConnectionObj.Close();
        }

        public List<int> GetVisitorID(ZoneType zone)
        {
            List<int>visitorIDList =new List<int>();
            dbGateway.SqlCommandObj.CommandText = "SELECT * FROM Relation_tbl WHERE ZoneTypeID='"+zone.ID+"'";
            dbGateway.SqlConnectionObj.Open();
            SqlDataReader reader = dbGateway.SqlCommandObj.ExecuteReader(); 
            int id = 0;
            while (reader.Read())
            {
                id = int.Parse(reader["VisitorID"].ToString());
                visitorIDList.Add(id);

            }
            reader.Close();
            dbGateway.SqlConnectionObj.Close();
            return visitorIDList;

        }
        public int GetNumberofVisitors(int ID)
        {
            
            dbGateway.SqlCommandObj.CommandText = "SELECT * FROM Relation_tbl WHERE ZoneTypeID='" + ID + "'";
            dbGateway.SqlConnectionObj.Open();
            SqlDataReader reader = dbGateway.SqlCommandObj.ExecuteReader();
            int visitorsNumber = 0;
            while (reader.Read())
            {
                visitorsNumber++;
            }
            
            reader.Close();
            dbGateway.SqlConnectionObj.Close();
            return visitorsNumber;

        }
        
    }
}
