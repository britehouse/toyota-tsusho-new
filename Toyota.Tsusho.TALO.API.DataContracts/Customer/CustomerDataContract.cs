using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Toyota.Tsusho.TALO.API.DataContracts.Customer
{
    /// <summary>
    /// Describes a Customer.
    /// </summary>
    [DataContract(Namespace = "http://www.ttaf.co.za/talo/api/2014/05/customer")]
    public class CustomerDataContract
    {
        [DataMember(Order = 0, IsRequired = true)]
        public string ID
        {
            get;
            set;
        }

        [DataMember(Order = 1, IsRequired = false)]
        public string Division
        {
            get;
            set;
        }

        [DataMember(Order = 2, IsRequired = false)]
        public string Title
        {
            get;
            set;
        }

        [DataMember(Order = 3, IsRequired = false)]
        public string FirstName
        {
            get;
            set;
        }

        [DataMember(Order = 4, IsRequired = false)]
        public string MiddleName
        {
            get;
            set;
        }

        [DataMember(Order = 5, IsRequired = false)]
        public string Surname
        {
            get;
            set;
        }

        [DataMember(Order = 6, IsRequired = false)]
        public AddressDataContract Address
        {
            get;
            set;
        }

        [DataMember(Order = 7, IsRequired = false)]
        public PhoneNumbersDataContract PhoneNumbers
        {
            get;
            set;
        }

        [DataMember(Order = 8, IsRequired = false)]
        public EmailsDataContract EmailAddresses
        {
            get;
            set;
        }

        [DataMember(Order = 9, IsRequired = false)]
        public string Company
        {
            get;
            set;
        }

        [DataMember(Order = 10, IsRequired = false)]
        public string VAT
        {
            get;
            set;
        }

        [DataMember(Order = 11, IsRequired = true)]
        public ModificationEnumeration Modification
        {
            get;
            set;
        }

        [DataMember(Order = 12, IsRequired = true)]
        public DateTime Modified
        {
            get;
            set;
        }
    }
}
