 
 
using System;
using AutoMapper;
using Abp.Application.Services.Dto;
using Abp.Extensions;
using Abp.Runtime.Validation;
 using YoYoCMS.PhoneBook.Persons;
using YoYoCMS.PhoneBook.Persons.Dtos;

namespace YoYoCMS.PhoneBook.Persons.Mappers
{
	/// <summary>
    /// PersonDto映射配置
    /// </summary>
    public class PersonMapper : IMapper
    {

        public void CreateMappings()
        {
            Mapper.CreateMap<Person,PersonEditDto>();
            Mapper.CreateMap<Person, PersonListDto>();

            Mapper.CreateMap<PersonEditDto, Person>();
            Mapper.CreateMap<PersonListDto,Person>();
        }
    }
}