using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HubSpot.NET.Api
{
	[DataContract]
	public class BatchUpdateRequest<T>
	{
		[DataMember(Name = "inputs")]
		public List<T> Inputs { get; set; }
	}
}
