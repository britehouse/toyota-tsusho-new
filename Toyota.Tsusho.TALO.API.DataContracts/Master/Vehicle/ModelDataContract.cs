﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Toyota.Tsusho.TALO.API.DataContracts.Master.Vehicle
{
    /// <summary>
    /// Describes a vehicle model.
    /// </summary>
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/master/vehicle")]
    public class ModelDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public string Code
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = true)]
        public string Class
        {
            get;
            set;
        }

        [DataMember(Order = 2, IsRequired=true)]
        public string Description
        {
            get;
            set;
        }

        [DataMember(Order = 3, IsRequired = true)]
        public string BodyType
        {
            get;
            set;
        }

        [DataMember(Order = 4, IsRequired=true)]
        public string PackageDivision
        {
            get;
            set;
        }

        [DataMember(Order = 5, IsRequired = true)]
        public ModificationEnumeration Modification
        {
            get;
            set;
        }

        [DataMember(Order = 6, IsRequired = true)]
        public DateTime Modified
        {
            get;
            set;
        }
    }
}
