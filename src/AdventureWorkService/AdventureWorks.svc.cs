using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Services;
using System.Data.Services.Common;
using System.Data.Services.Providers;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace AdventureWorkService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdventureWorks" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AdventureWorks.svc or AdventureWorks.svc.cs at the Solution Explorer and start debugging.
    public class AdventureWorks : EntityFrameworkDataService<AdventureWorks>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.UseVerboseErrors = true;
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
            config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
        }
    }
}
