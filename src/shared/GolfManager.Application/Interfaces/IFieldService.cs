using GolfManager.Application.Dtos.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Application.Interfaces
{
    public interface IFieldService
    {
        Task<List<FieldDto>> GetAllFields();
        Task<FieldDto> GetFieldById(int id);
        Task AddField(CreateUpdateFieldDto field);
    }
}
