using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk.Client;

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

                new_modelsalescode material = null;

                material = (from m in context.new_modelsalescodeSet
                            where m.new_name == "LJ150R-GKMEE"
                            select m).FirstOrDefault();

                Assert.IsNotNull(material, "Model Sales Code LJ150R-GKMEE not found");
            }

        }
    }
}
