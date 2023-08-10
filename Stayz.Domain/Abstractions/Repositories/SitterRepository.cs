using System;
using Stayz.Domain.Models;

namespace Stayz.Domain.Abstractions.Repositories
{
	public interface ISitterRepository
	{
		Task<List<Sitter>> GetAllSittersAsync();
		Task<Sitter> GetSitterByIdAsync(int id);
		Task<Sitter> CreateSitterAsync(Sitter sitter);
        Task<Sitter> UpdateSitterAsync(Sitter updatedSitter);
        Task<Sitter> DeleteSitterAsync(int id);

		Task<List<Stay>> ListSitterStaysAsync();
		Task<Stay> GetSitterStayByIdAsync(int sitterId, int stayId);
		Task<Stay> CreateSitterStayAsync(int sitterId, Stay stay);
		Task<Stay> UpdateSitterStayAsync(int sitterId, Stay updatedStay);
		Task<Stay> DeleteSitterStayAsync(int sitterId, int stayId);
	}
}

