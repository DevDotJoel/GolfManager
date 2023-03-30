
using AutoMapper;
using GolfManager.Application.Dtos.Event;
using GolfManager.Application.Dtos.Field;
using GolfManager.Application.Interfaces;
using GolfManager.Domain.Common;
using GolfManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Application.Services
{
    public class FieldService : IFieldService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public FieldService(IUnitOfWork unitOfWork,IMapper mapper)
        {

            _unitOfWork= unitOfWork;
            _mapper= mapper;
        }
        public async Task<FieldDto> AddField(CreateUpdateFieldDto field)
        {
            var fieldToAdd = new Field(field.Name, field.Description, field.Capacity);
            await _unitOfWork.FieldRepository.AddAsync(fieldToAdd);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<FieldDto>(fieldToAdd);
        }

        public async Task<List<FieldDto>> GetAllFields()
        {
            return _mapper.Map<List<FieldDto>>(await _unitOfWork.FieldRepository.GetAllAsync());
        }

        public async Task<FieldDto> GetFieldById(int id)
        {
          return _mapper.Map<FieldDto>(await _unitOfWork.FieldRepository.GetByIdAsync(id));
        }

        public async Task<FieldDto> UpdateField(CreateUpdateFieldDto field)
        {
            var currentField = await _unitOfWork.FieldRepository.GetByIdAsync(field.Id);
            currentField.SetName(field.Name);
            currentField.SetDescription(field.Description);
            _unitOfWork.FieldRepository.Update(currentField);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<FieldDto>(currentField);
        }
    }
}
