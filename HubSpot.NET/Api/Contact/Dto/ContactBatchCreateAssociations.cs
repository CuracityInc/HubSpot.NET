using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HubSpot.NET.Api.Contact.Dto
{
	public class ContactBatchCreateAssociations
	{
        [DataMember(Name = "to")]
        public AssociationObjectId To { get; set; }

        [DataMember(Name = "types")]
        public List<AssociationLabelTypes> Types { get; set; }
    }
}

