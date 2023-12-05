using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HubSpot.NET.Api.Contact.Dto
{
    [DataContract]
	public class ContactBatchCreateRequestInput
    {
        [DataMember(Name = "properties")]
        public ContactHubSpotModel Properties { get; set; }

        [DataMember(Name = "associations")]
        public List<ContactBatchCreateAssociations> Associations { get; set; }
    }
}
