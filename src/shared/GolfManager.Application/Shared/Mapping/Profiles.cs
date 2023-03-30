using AutoMapper;
using GolfManager.Application.Dtos.Customer;
using GolfManager.Application.Dtos.Event;
using GolfManager.Application.Dtos.Field;
using GolfManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Application.Shared.Mapping
{
    public class Profiles:Profile
    {
        public Profiles()
        {
            CreateMap<Event, EventDto>();
            CreateMap<Field, FieldDto>();
            CreateMap<Customer, CustomerDto>();
        }
    }
}
