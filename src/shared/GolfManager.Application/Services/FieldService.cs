
using AutoMapper;
using GolfManager.Application.Dtos.Field;
using GolfManager.Application.Interfaces;
using GolfManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Application.Services
{
    public class FieldService : IFieldService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        public FieldService(IUnitOfWork)
        {

        }
        public Task AddField(CreateUpdateFieldDto field)
        {
            throw new NotImplementedException();
        }

        public Task<List<FieldDto>> GetAllFields()
        {
            throw new NotImplementedException();
        }

        public Task<FieldDto> GetFieldById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
