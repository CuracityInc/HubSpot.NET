using HubSpot.NET.Api.Notes.Dto;
using HubSpot.NET.Core;
using HubSpot.NET.Core.Interfaces;
using RestSharp;
 
namespace HubSpot.NET.Api.Notes
{
	public class HubSpotNotesApi : IHubSpotNotesApi
	{
		private readonly IHubSpotClient _client;

		public HubSpotNotesApi(IHubSpotClient client)
		{
			_client = client;
		}

		/// <summary>
		/// Creates a note
		/// </summary>
		/// <param name="entity">The note to create</param>
		/// <returns>The created note</returns>
		public T Create<T>(T entity) where T : NoteHubSpotModel, new()
		{
            var data = _client.Execute<T>(entity.RouteBasePath, entity, Method.Post, false);
			return data;
		}
	}
}
