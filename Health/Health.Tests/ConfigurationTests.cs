using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Health.Common.Confiduration;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Health.Tests
{
    [TestClass]
    public class ConfigurationTests
    {
        [TestMethod]
        public void BuildTALOChecks()
        {
            Common.Confiduration.Checks checks = new Common.Confiduration.Checks()
            { 
                new Common.Confiduration.Check()
                {
                    Id = "Toyota.Tsusho.TALO.Services.Generic.WCF-WSHTTP",
                    Description = "Checks that the 'Toyota.Tsusho.TALO.Services.Generic.WCF-WSHTTP' receive location is enabled.",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Check BizTalk Receive Location.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"ReceiveLocationName", "Toyota.Tsusho.TALO.Services.Generic.WCF-WSHTTP"} 
                    },
                    Interval = new TimeSpan(0, 6, 0, 0, 0)
                },
                new Common.Confiduration.Check()
                {
                    Id = "Toyota.Tsusho.TALO.Services.Generic.Response.WCF-WSHTTP",
                    Description = "Checks that the 'Toyota.Tsusho.TALO.Services.Generic.Response.WCF-WSHTTP' receive location is enabled.",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Check BizTalk Receive Location.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"ReceiveLocationName", "Toyota.Tsusho.TALO.Services.Generic.Response.WCF-WSHTTP"} 
                    },
                    Interval = new TimeSpan(0, 6, 0, 0, 0)
                },
                new Common.Confiduration.Check()
                {
                    Id = "TALO.Services",
                    Description = "Checks that the TALO Services are available",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Ping Service.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"url", "http://localhost/Toyota.Tsusho.TALO.API/OrderService.svc"} 
                    },
                    Interval = new TimeSpan(0, 0, 30, 0, 0)
                },
                new Common.Confiduration.Check()
                {
                    Id = "TALO.BizTalk.Services",
                    Description = "Checks that the TALO BizTalk Services are available",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Ping Service.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"url", "http://localhost/Toyota.Tsusho.TALO.Services.Generic.WCF/OnRamp.svc"} 
                    },
                    Interval = new TimeSpan(0, 0, 30, 0, 0)
                },
                new Common.Confiduration.Check()
                {
                    Id = "TALO.BizTalk.Services.Response",
                    Description = "Checks that the TALO BizTalk Response Services are available",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Ping Service.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"url", "http://localhost/Toyota.Tsusho.TALO.Services.Generic.WCF.Response/OnRamp.svc"} 
                    },
                    Interval = new TimeSpan(0, 0, 30, 0, 0)
                }
            };

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(checks.GetType());

            using(Stream stream = new FileStream(@"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\TALO Checks.json", FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.WriteObject(stream, checks);
            }
        }

        [TestMethod]
        public void BuildTALOSAPChecks()
        {
            Common.Confiduration.Checks checks = new Common.Confiduration.Checks()
            { 
                new Common.Confiduration.Check()
                {
                    Id = "Toyota.Tsusho.SAP.Services.TALO.OnRamp.WCF-SAP",
                    Description = "Checks that the 'Toyota.Tsusho.SAP.Services.TALO.OnRamp.WCF-SAP' receive location is enabled.",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Check BizTalk Receive Location.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"ReceiveLocationName", "Toyota.Tsusho.SAP.Services.TALO.OnRamp.WCF-SAP"} 
                    },
                    Interval = new TimeSpan(0, 0, 10, 0, 0)
                },
            };

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(checks.GetType());

            using (Stream stream = new FileStream(@"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\TALO SAP Checks.json", FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.WriteObject(stream, checks);
            }
        }

        [TestMethod]
        public void BuildCRMSAPChecks()
        {
            Common.Confiduration.Checks checks = new Common.Confiduration.Checks()
            { 
                new Common.Confiduration.Check()
                {
                    Id = "Toyota.Tsusho.SAP.Services.CRM.OnRamp.WCF-SAP",
                    Description = "Checks that the 'Toyota.Tsusho.SAP.Services.CRM.OnRamp.WCF-SAP' receive location is enabled.",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Check BizTalk Receive Location.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"ReceiveLocationName", "Toyota.Tsusho.SAP.Services.CRM.OnRamp.WCF-SAP"} 
                    },
                    Interval = new TimeSpan(0, 0, 10, 0, 0)
                },
            };

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(checks.GetType());

            using (Stream stream = new FileStream(@"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\CRM SAP Checks.json", FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.WriteObject(stream, checks);
            }
        }

        [TestMethod]
        public void BuildSAPChecks()
        {
            Common.Confiduration.Checks checks = new Common.Confiduration.Checks()
            { 
                new Common.Confiduration.Check()
                {
                    Id = "SAP.Server",
                    Description = "Checks that the SAP Server is available",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Ping Server.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"Server", "172.29.2.13"} 
                    },
                    Interval = new TimeSpan(0, 0, 5, 0, 0)
                }
            };

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(checks.GetType());

            using (Stream stream = new FileStream(@"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\SAP Checks.json", FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.WriteObject(stream, checks);
            }
        }

        [TestMethod]
        public void BuildCRMChecks()
        {
            Common.Confiduration.Checks checks = new Common.Confiduration.Checks()
            { 
                new Common.Confiduration.Check()
                {
                    Id = "Toyota.Tsusho.CRM.Services.Generic.WCF-WSHTTP",
                    Description = "Checks that the 'Toyota.Tsusho.CRM.Services.Generic.WCF-WSHTTP' receive location is enabled.",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Check BizTalk Receive Location.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"ReceiveLocationName", "Toyota.Tsusho.CRM.Services.Generic.WCF-WSHTTP"} 
                    },
                    Interval = new TimeSpan(0, 6, 0, 0, 0)
                },
                new Common.Confiduration.Check()
                {
                    Id = "Toyota.Tsusho.CRM.Services.Generic.Response.WCF-WSHTTP",
                    Description = "Checks that the 'Toyota.Tsusho.CRM.Services.Generic.Response.WCF-WSHTTP' receive location is enabled.",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Check BizTalk Receive Location.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"ReceiveLocationName", "Toyota.Tsusho.CRM.Services.Generic.Response.WCF-WSHTTP"} 
                    },
                    Interval = new TimeSpan(0, 6, 0, 0, 0)
                },
                new Common.Confiduration.Check()
                {
                    Id = "CRM.Services",
                    Description = "Checks that the CRM Services are available",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Ping Service.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"url", "http://localhost/Toyota.Tsusho.TALO.API/OrderService.svc"} 
                    },
                    Interval = new TimeSpan(0, 0, 30, 0, 0)
                },
                new Common.Confiduration.Check()
                {
                    Id = "CRM.BizTalk.Services",
                    Description = "Checks that the CRM BizTalk Services are available",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Ping Service.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"url", "http://localhost/Toyota.Tsusho.CRM.Services.Generic.WCF/OnRamp.svc"} 
                    },
                    Interval = new TimeSpan(0, 0, 30, 0, 0)
                },
                new Common.Confiduration.Check()
                {
                    Id = "CRM.BizTalk.Services.Response",
                    Description = "Checks that the CRM BizTalk Response Services are available",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Ping Service.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"url", "http://localhost/Toyota.Tsusho.CRM.Services.Generic.WCF.Response/OnRamp.svc"} 
                    },
                    Interval = new TimeSpan(0, 0, 30, 0, 0)
                },
                new Common.Confiduration.Check()
                {
                    Id = "CRM.Organization.Service",
                    Description = "Checks that the CRM Organization Service is available",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Ping Service.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"url", "http://tmau-por-crm01/TMAU/XRMServices/2011/Organization.svc"} 
                    },
                    Interval = new TimeSpan(0, 0, 30, 0, 0)
                }
            };

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(checks.GetType());

            using (Stream stream = new FileStream(@"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\CRM Checks.json", FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.WriteObject(stream, checks);
            }
        }

        [TestMethod]
        public void BuildBizTalkChecks()
        {
            Common.Confiduration.Checks checks = new Common.Confiduration.Checks()
            { 
                new Common.Confiduration.Check()
                {
                    Id = "BizTalk.BTSSvc$BizTalkServerApplication",
                    Description = "Checks that the 'BTSSvc$BizTalkServerApplication' service is running.",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Check Service.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"Service", "BTSSvc$BizTalkServerApplication"} 
                    },
                    Interval = new TimeSpan(0, 0, 0, 10, 0)
                },
                new Common.Confiduration.Check()
                {
                    Id = "BizTalk.MSSQLSERVER",
                    Description = "Checks that the 'MSSQLSERVER' service is running.",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Check Service.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"Service", "MSSQLSERVER"} 
                    },
                    Interval = new TimeSpan(0, 0, 0, 10, 0)
                },
                new Common.Confiduration.Check()
                {
                    Id = "BizTalk.SQLSERVERAGENT",
                    Description = "Checks that the 'SQLSERVERAGENT' service is running.",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Check Service.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"Service", "SQLSERVERAGENT"} 
                    },
                    Interval = new TimeSpan(0, 0, 0, 10, 0)
                },
                new Common.Confiduration.Check()
                {
                    Id = "BizTalk.DiskSpace",
                    Description = "Checks that the BizTalk Server has enough disk space.",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Check Disk Space.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"threshold", 20} 
                    },
                    Interval = new TimeSpan(0, 0, 5, 0, 0)
                },
                new Common.Confiduration.Check()
                {
                    Id = "BizTalk.Memory",
                    Description = "Checks that BizTalk Server has enough memory available",
                    Script = @"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\Check Memory.ps1",
                    Parameters = new System.Collections.Generic.Dictionary<string,object>()
                    { 
                        {"threshold", 20} 
                    },
                    Interval = new TimeSpan(0, 0, 5, 0, 0)
                },
            };

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(checks.GetType());

            using (Stream stream = new FileStream(@"C:\Projects\Toyota.Tsusho\Health\Health.Tests\Checks\BizTalk Checks.json", FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.WriteObject(stream, checks);
            }
        }
    }
}
