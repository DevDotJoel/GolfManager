using GolfManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Domain.Common
{
    public interface IUnitOfWork
    {
        IEventRepository EventRepository { get; }
        IFieldRepository FieldRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        Task SaveChangesAsync();
    }
}
