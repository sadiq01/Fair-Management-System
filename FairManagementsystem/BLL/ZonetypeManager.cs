using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using FairManagementsystem.DAL.DAO;
using FairManagementsystem.DAL.Gateway;

namespace FairManagementsystem.BLL
{
    class ZoneTypeManager
    {
        ZoneTypeGateway zoneTypeGateway=new ZoneTypeGateway();
        RelationGateway relation=new RelationGateway();
        VisitorGateway visitorGateway=new VisitorGateway();

        public string Save(ZoneType aZoneType)
        {
            if (zoneTypeGateway.Save(aZoneType) > 0)
            {
                return " Successfully Save !";
            }
            else
            {
                return "Save Failed !";
            }

        }

        public List<ZoneType> ZoneList()
        {
            return zoneTypeGateway.GetAllZone();
        }

        public List<int> ZoneTypeVisitor(ZoneType zone)
        {
            List<int>visitorIDList =new List<int>();
           
            visitorIDList = relation.GetVisitorID(zone);
           
            return visitorIDList;

        }

        public List<ZoneType> GetZone(out Queue<int> zoneVisitors)
        {
            List<ZoneType> zoneList =new List<ZoneType>();
            zoneList = zoneTypeGateway.GetAllZone();
            int visitorNumber;
            zoneVisitors=new Queue<int>();
            foreach (ZoneType zone in zoneList)
            {
                visitorNumber = relation.GetNumberofVisitors(zone.ID);
                zoneVisitors.Enqueue(visitorNumber);

            }

            return zoneList;

        } 
    }
}
