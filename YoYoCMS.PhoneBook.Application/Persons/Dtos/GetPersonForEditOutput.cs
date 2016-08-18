using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Extensions;
using YoYoCMS.PhoneBook.Persons;

namespace YoYoCMS.PhoneBook.Persons.Dtos
{
	/// <summary>
    /// 用于添加或编辑 联系人时使用的DTO
    /// </summary>
  
    public class GetPersonForEditOutput : IOutputDto
    {
 

	      /// <summary>
         /// Person编辑状态的DTO
        /// </summary>
    public PersonEditDto Person{get;set;}


    }
}
