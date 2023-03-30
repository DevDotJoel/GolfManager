using AutoMapper;
using GolfManager.Application.Dtos.Customer;
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
    public class CustomerService:ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CustomerService( IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<CustomerDto> AddCustomer(CreateUpdateCustomerDto customer)
        {
            var customerToAdd = new Customer(customer.Name,customer.PhoneNumber);
            await _unitOfWork.CustomerRepository.AddAsync(customerToAdd);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<CustomerDto>(customerToAdd);
        }

        public async Task<List<CustomerDto>> GetAllCustomers()
        {
           return _mapper.Map<List<CustomerDto>>(await _unitOfWork.CustomerRepository.GetAllAsync());
        }

        public async Task<CustomerDto> GetCustomerById(int id)
        {
            return _mapper.Map<CustomerDto>(await _unitOfWork.CustomerRepository.GetByIdAsync(id));
        }
    }
}
