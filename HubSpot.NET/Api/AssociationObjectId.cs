using System.Runtime.Serialization;

namespace HubSpot.NET.Api
{
    public class AssociationObjectId
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}
