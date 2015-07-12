using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using FairManagementsystem.DAL.DAO;
using FairManagementsystem.DAL.Gateway;

namespace FairManagementsystem.BLL
{
    class VisitorManager
    {
        
        Visitor newVisitor=new Visitor();
        VisitorGateway visitorGateway=new VisitorGateway();
        

        public bool CheckVisitorInfo(Visitor aVisitor,out string message)
        {
            if (aVisitor.Name == "")
            {
                message = "Name is not inserted";
                return false;

            }
             else if (aVisitor.ContactNo == "")
            {
                message = "Contact Number is not inserted";
                return false;

            }
            else if (aVisitor.Email == "")
            {
                message = "Email is not inserted";
                return false;

            }
            else if (visitorGateway.IsEmailExist(aVisitor.Email))
            {
                message = "Email is exist";
                return false;
            }
            else
            {
                message = "Saved visitor information Successfully";
                return true;
            }
        }
        public string Save(Visitor aVisitor,List<string> zoneVisit )
        {
            if (visitorGateway.SaveVisitorInformation(aVisitor,zoneVisit) > 0)
            {
                return " Successfully Save !";
            }
            else
            {
                return "Save Failed !";
            }

        }

        public Visitor GetVisitorInfo(int id)
        {
            return visitorGateway.GetVisitorDetails(id);

        } 


    }
}
