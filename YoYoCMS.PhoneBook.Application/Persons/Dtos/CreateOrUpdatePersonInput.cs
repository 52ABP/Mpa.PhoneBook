using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using Abp.Extensions;
using YoYoCMS.PhoneBook.Persons;

namespace YoYoCMS.PhoneBook.Persons.Dtos
{
    /// <summary>
    /// 联系人新增和编辑时用Dto
    /// </summary>
    
    public class CreateOrUpdatePersonInput : IInputDto
    {

		public PersonEditDto  PersonEditDto {get;set;}
 
    }
}
