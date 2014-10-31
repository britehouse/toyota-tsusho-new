using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk;

namespace Toyota.Tsusho.CRM.API.Testing
{
    [TestClass]
    public class LookupTests
    {
        [TestMethod]
        public void LookupMaterial()
        {
            using (OrganizationServiceProxy proxy = CRMHelper.Connect())
            {
                ServiceContext context = new ServiceContext(proxy);

                Entity entity = (from it in context.CreateQuery("new_invoicetype")
                          where it["new_typeidinvoice"] == "07"
                          select it).FirstOrDefault();

                Console.WriteLine(entity.Id);
            }

        }
    }
}
