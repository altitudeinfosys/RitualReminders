using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using RitualReminders.Dtos;
using RitualReminders.Models;

namespace RitualReminders
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {

            Mapper.CreateMap<Todo, TodoDto>();
            Mapper.CreateMap<TodoDto, Todo>();

        }

    }
}