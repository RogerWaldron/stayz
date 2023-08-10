using System;
using Stayz.Domain.Abstractions.Repositories;
using Stayz.Domain.Models;

using Microsoft.EntityFrameworkCore;


namespace Stayz.Dal.Repositories
{
	public class SitterRepository: ISitterRepository
	{
		private readonly DataContext _ctx;
		private int _nextId = 1;

		public SitterRepository(DataContext ctx)
		{
			_ctx = ctx;
		}

		public async Task<List<Sitter>> GetAllSittersAsync()
		{
			return await _ctx.Sitters.ToListAsync();
		}

		public async Task<Sitter> GetSitterByIdAsync(int id)
		{
			var sitter = await _ctx.Sitters
				.Include(s => s.Stays)
				.FirstOrDefault(s => s.Id == id);

			if (sitter == null)
				return null;

			return sitter;
		}

        public async Task<Sitter> CreateSitterAsync(Sitter sitter)
        {
            _ctx.Sitters.Add(sitter);
            await _ctx.SaveChangesAsync();

            return sitter;
        }

        public async Task<Sitter> UpdateSitterAsync(Sitter updatedSitter)
        {
            _ctx.Sitters.Update(updatedSitter);
            await _ctx.SaveChangesAsync();

            return updatedSitter;
        }

        Task<Sitter> ISitterRepository.DeleteSitterAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Stay>> ISitterRepository.ListSitterStaysAsync()
        {
            throw new NotImplementedException();
        }

        Task<Stay> ISitterRepository.GetSitterStayByIdAsync(int sitterId, int stayId)
        {
            throw new NotImplementedException();
        }

        Task<Stay> ISitterRepository.CreateSitterStayAsync(int sitterId, Stay stay)
        {
            throw new NotImplementedException();
        }

        Task<Stay> ISitterRepository.UpdateSitterStayAsync(int sitterId, Stay updatedStay)
        {
            throw new NotImplementedException();
        }

        Task<Stay> ISitterRepository.DeleteSitterStayAsync(int sitterId, int stayId)
        {
            throw new NotImplementedException();
        }
    }
}

