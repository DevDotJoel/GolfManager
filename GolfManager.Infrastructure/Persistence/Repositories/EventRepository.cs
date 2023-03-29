using GolfManager.Domain.Entities;
using GolfManager.Domain.Interfaces;
using GolfManager.Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Infrastructure.Persistence.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly GolfManagerContext _context;
        public EventRepository(GolfManagerContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Event entity)
        {
            await _context.AddAsync(entity);
        }

        public void Delete(Event entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Event>> GetAllAsync()
        {
           return await _context.Events.AsNoTracking().ToListAsync();
        }

        public Task<ICollection<Event>> GetAllWithPagination(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<Event> GetByIdAsync(int id)
        {
          return await _context.Events.AsNoTracking().Where(e=> e.Id== id).FirstOrDefaultAsync();
        }

        public void Update(Event entity)
        {
            _context.Events.Update(entity);
        }
    }
}
