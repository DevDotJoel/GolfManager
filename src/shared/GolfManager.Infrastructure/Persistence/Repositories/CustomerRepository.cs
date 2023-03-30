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
    public class CustomerRepository : ICustomerRepository
    {
        private readonly GolfManagerContext _context;
        public CustomerRepository(GolfManagerContext context)
        {
            _context = context;

        }
        public async Task AddAsync(Customer entity)
        {
          await _context.AddAsync(entity);
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Customer>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public Task<ICollection<Customer>> GetAllWithPagination(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _context.Customers.AsNoTracking().Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public void Update(Customer entity)
        {
            _context.Customers.Update(entity);
        }
    }
}
