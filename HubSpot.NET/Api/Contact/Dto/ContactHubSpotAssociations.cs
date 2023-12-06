using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HubSpot.NET.Api.Contact.Dto
{
	public class ContactHubSpotAssociations
	{
		[DataMember(Name = "companyAssociations")]
		public List<AssociationResult> CompanyAssociations { get; set; }
    }
}
