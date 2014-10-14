using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.Serialization;
using System.IO;
using Toyota.Tsusho.CRM.API.MessageContracts;

namespace Toyota.Tsusho.CRM.API.Testing
{
    [TestClass]
    public class SerializationTests
    {
        [TestMethod]
        public void TestOrderRequest()
        {
            using(Stream stream = new FileStream(@"C:\Projects\Toyota.Tsusho\05 OrderNotifyRequestMessage.xml", FileMode.Open, FileAccess.Read))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(Toyota.Tsusho.CRM.API.MessageContracts.OrderNotifyRequestMessage), "OrderNotifyRequestMessage", "http://www.ttaf.co.za/crm/api/2014/08");

                object order = serializer.ReadObject(stream);

                Console.Write(order);

                //Console.WriteLine(order.Items[0].Invoice.invoice_details.Count);
            }
        }
    }
}
