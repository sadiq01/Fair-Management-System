using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairManagementsystem.DAL.DAO;


namespace FairManagementsystem.DAL.Gateway
{
    public class VisitorGateway
    {
       DBGateway dbGateway=new DBGateway();
     ZoneTypeGateway zoneGateway=new ZoneTypeGateway();
        RelationGateway relationship=new RelationGateway();

       

        public bool IsEmailExist(string email)
        {
            bool result = false;
            dbGateway.SqlCommandObj.CommandText = "SELECT * FROM VisitorInfo_tbl WHERE Email ='"+email+"'";
            dbGateway.SqlConnectionObj.Open();
            SqlDataReader reader = dbGateway.SqlCommandObj.ExecuteReader();
            while (reader.Read())
            {
                result = true;
                break;
            }
            reader.Close();
            dbGateway.SqlConnectionObj.Close();
            return result;
        }
        public int SaveVisitorInformation(Visitor visitorInfo,List<string> zoneVisit )
        {

            dbGateway.SqlCommandObj.CommandText = "INSERT INTO VisitorInfo_tbl(Name,Email,Contact_No) VALUES('" + visitorInfo.Name + "','" + visitorInfo.Email + "','" + visitorInfo.ContactNo + "')";
            dbGateway.SqlConnectionObj.Open();
            int rowAffected = dbGateway.SqlCommandObj.ExecuteNonQuery();
            dbGateway.SqlConnectionObj.Close();
            int visitorId = GetVisitorID(visitorInfo.Email);
            int zoneID = 0;
            foreach (string zone in zoneVisit)
            {
                zoneID = zoneGateway.GetZoneID(zone);
                relationship.SaveRelation(visitorId,zoneID);

            }
           

            return rowAffected;
        }
        public int GetVisitorID(string email)
        {
            int visitorId = 0;
            dbGateway.SqlCommandObj.CommandText = "SELECT * FROM VisitorInfo_tbl WHERE Email ='" + email + "'";
            dbGateway.SqlConnectionObj.Open();
            SqlDataReader reader = dbGateway.SqlCommandObj.ExecuteReader();
            while (reader.Read())
            {
                visitorId = int.Parse(reader[0].ToString());
                break;
            }
            reader.Close();
            dbGateway.SqlConnectionObj.Close();
            return visitorId;
        }

        public Visitor GetVisitorDetails(int visitorID)
        {
            Visitor visitorDetails=new Visitor();
            dbGateway.SqlCommandObj.CommandText = "SELECT * FROM VisitorInfo_tbl WHERE ID='"+visitorID+"'";
            dbGateway.SqlConnectionObj.Open();
            SqlDataReader reader = dbGateway.SqlCommandObj.ExecuteReader();
            while (reader.Read())
            {
                visitorDetails.Name = reader[1].ToString();
                visitorDetails.Email = reader[2].ToString();
                visitorDetails.ContactNo = reader[3].ToString();
            }
            reader.Close();
            dbGateway.SqlConnectionObj.Close();
            return visitorDetails;
        }
      
        
    }
}
