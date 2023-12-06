using System.Runtime.Serialization;

namespace HubSpot.NET.Api.Contact.Dto
{
    [DataContract]
    public class ContactBatchUpdateRequestInput
    {
        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "properties")]
        public ContactHubSpotModel Properties { get; set; }
    }
}
