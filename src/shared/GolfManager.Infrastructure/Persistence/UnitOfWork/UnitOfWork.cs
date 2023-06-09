﻿using GolfManager.Domain.Common;
using GolfManager.Domain.Interfaces;
using GolfManager.Infrastructure.Persistence.Data;
using GolfManager.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Infrastructure.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IEventRepository EventRepository { get; set; }
        public IFieldRepository FieldRepository { get; set; }
        public ICustomerRepository CustomerRepository { get; set; }

        private GolfManagerContext _context;
        public UnitOfWork( GolfManagerContext context)
        {
            EventRepository = new EventRepository(context);
            FieldRepository= new FieldRepository(context);
            CustomerRepository= new CustomerRepository(context);
            _context = context;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
