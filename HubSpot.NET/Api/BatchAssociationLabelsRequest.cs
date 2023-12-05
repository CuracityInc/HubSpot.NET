using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HubSpot.NET.Api
{
    public class BatchAssociationLabelsRequest
    {
        [DataMember(Name = "inputs")]
        public List<BatchAssociationLabelsInputList> Inputs { get; set; }
    }

    public enum AssociationObjectType { contact, company, deal }
}
