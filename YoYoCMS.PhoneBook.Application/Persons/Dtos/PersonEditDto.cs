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
    /// 联系人编辑用Dto
    /// </summary>
    [AutoMap(typeof(Person))]
    public class PersonEditDto 
    {

	/// <summary>
    ///   主键Id
    /// </summary>
	public int? Id{get;set;}

        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(32)]
        public   string  Name { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        [MaxLength(225)]
        public   string  EmailAddress { get; set; }

    }
}
