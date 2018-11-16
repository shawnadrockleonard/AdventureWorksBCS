using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace AdventureWorksSimple
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SimpleData" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SimpleData.svc or SimpleData.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class SimpleData : ISimpleData
    {
        private List<EmployeeModel> _emps = new List<EmployeeModel>()
        {
            new EmployeeModel() { DisplayName = "Shawn", Name = "Awesome Guy", Url = "https://mysite.com/shawn" },
            new EmployeeModel() { DisplayName = "John", Name = "cool Guy", Url = "https://mysite.com/john" }
        };

        public IList<EmployeeModel> GetEmployees()
        {
            return _emps;
        }
    }
}
