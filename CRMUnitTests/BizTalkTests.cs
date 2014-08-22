using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRMUnitTests
{
    [TestClass]
    public class BizTalkTests
    {
        [TestMethod]
        public void ContactPublish()
        {
            ContactServiceClient client = new ContactServiceClient();

            client.Publish(new Toyota.Tsusho.CRM.API.MessageContracts.ContactPublishRequestMessage()
            {
                Contact = new Toyota.Tsusho.CRM.API.Contact()
                {
                    FirstName = "Test",
                    LastName = "Testing"
                }
            }
            );
        }
    }
}
