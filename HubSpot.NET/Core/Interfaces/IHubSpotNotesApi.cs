using HubSpot.NET.Api.Notes.Dto;

namespace HubSpot.NET.Core.Interfaces
{
	public interface IHubSpotNotesApi
	{
		T Create<T>(T entity) where T : NoteHubSpotModel, new();
	}
}
