using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using HubSpot.NET.Core.Interfaces;

namespace HubSpot.NET.Api.Notes.Dto
{
	/// <summary>
	/// Models an Note entity within HubSpot.
	/// </summary>
	[DataContract]
	public class NoteHubSpotModel : IHubSpotModel
	{
		[DataMember(Name = "noteId")]
		[IgnoreDataMember]
		public long? Id { get; set; }

		[DataMember(Name = "properties")]
		public FileProperties Properties { get; set; }

		[DataMember(Name = "associations")]
		public List<NoteAssociations> Associations { get; set; }

		public string RouteBasePath => "/crm/v3/objects/notes";

		public bool IsNameValue { get; }
		public void ToHubSpotDataEntity(ref dynamic dataEntity) { }
		public void FromHubSpotDataEntity(dynamic hubspotData) { }
	}

	// TODO Improve for naming conventions before creating Chinchilla PR
	public class FileProperties
	{
		[DataMember(Name = "hs_timestamp")]
		public DateTime? hs_timestamp { get; set; }

		[DataMember(Name = "hubspot_owner_id")]
		public long? hubspot_owner_id { get; set; }

		[DataMember(Name = "hs_note_body")]
		public string hs_note_body { get; set; }

		/// <summary>
		/// The IDs of the note's attachments.
		/// Multiple attachment IDs are separated by a semi-colon.
		/// </summary>
		[DataMember(Name = "hs_attachment_ids")]
		public string hs_attachment_ids { get; set; }
	}

	public class NoteAssociations
	{
		[DataMember(Name = "to")]
		public AssociationObjectId To { get; set; }

		[DataMember(Name = "types")]
		public List<AssociationLabelTypes> Types { get; set; }
	}
}
