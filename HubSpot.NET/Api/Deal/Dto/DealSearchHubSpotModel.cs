using System.Collections.Generic;
using System.Runtime.Serialization;
using HubSpot.NET.Core.Interfaces;

namespace HubSpot.NET.Api.Deal.Dto
{
	public class DealSearchHubSpotModel<T> : IHubSpotModel where T : DealHubSpotModel, new()
	{
		[DataMember(Name = "total")]
		public long Total { get; set; }

		[DataMember(Name = "paging")]
		public PagingModel Paging { get; set; }

		[DataMember(Name = "results")]
		public IList<T> Results { get; set; } = new List<T>();

		public string RouteBasePath => "/crm/v3/objects/deals";

		public bool IsNameValue => false;

		public virtual void ToHubSpotDataEntity(ref dynamic converted) { }

		public virtual void FromHubSpotDataEntity(dynamic hubspotData) { }
	}
}
