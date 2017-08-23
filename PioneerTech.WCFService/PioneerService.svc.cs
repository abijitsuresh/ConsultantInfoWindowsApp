using PioneerTechSystem.DAL;
using PioneerTechSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PioneerTech.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class PioneerService : IPioneerService
    {

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        

        public int loginCheck(Login loginObj)
        {            
            EmployeeDataAccessLayer EmployeeDataAccessLayerObj = new EmployeeDataAccessLayer();
            int returnValue;
            if (EmployeeDataAccessLayerObj.loginCheck(loginObj) == 1)
            {
                returnValue = 1;
            }
            else
                returnValue = 0;
            return returnValue;
        }
    }
}
