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
    public class FieldRepository : IFieldRepository
    {
        private readonly GolfManagerContext _context;
        public FieldRepository(GolfManagerContext context)
        {
            _context = context;

        }
        public async Task AddAsync(Field entity)
        {
           await _context.AddAsync(entity);
        }

        public void Delete(Field entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Field>> GetAllAsync()
        {
            return await _context.Fields.AsNoTracking().ToListAsync();
        }

        public Task<ICollection<Field>> GetAllWithPagination(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<Field> GetByIdAsync(int id)
        {
            return await _context.Fields.AsNoTracking().Where(f => f.Id == id).FirstOrDefaultAsync();
        }

        public void Update(Field entity)
        {
            _context.Fields.Update(entity);
        }
    }
}
