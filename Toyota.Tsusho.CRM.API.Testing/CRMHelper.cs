using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using System.ServiceModel.Description;

namespace Toyota.Tsusho.CRM.API.Testing
{
    internal static class CRMHelper
    {
        public static OrganizationServiceProxy Connect()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["CRM"];

            if (settings == null)
                throw new ConfigurationErrorsException("No CRM Connection String was found.");

            Uri uri = new Uri(settings.ConnectionString);

            ClientCredentials credentials = null;

            string user = ConfigurationManager.AppSettings["User"];
            string password = ConfigurationManager.AppSettings["Password"];

            if (!string.IsNullOrWhiteSpace(user))
            {
                credentials = new ClientCredentials();

                credentials.UserName.UserName = user;
                credentials.UserName.Password = password;
            }

            OrganizationServiceProxy proxy = new OrganizationServiceProxy(uri, null, credentials, null);

            proxy.EnableProxyTypes();

            return proxy;
        }
    }
}
