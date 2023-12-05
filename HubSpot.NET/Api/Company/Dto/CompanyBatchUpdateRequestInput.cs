using System.Runtime.Serialization;

namespace HubSpot.NET.Api.Company.Dto
{
    [DataContract]
    public class CompanyBatchUpdateRequestInput
    {
        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "properties")]
        public CompanyHubSpotModel Properties { get; set; }
    }
}
