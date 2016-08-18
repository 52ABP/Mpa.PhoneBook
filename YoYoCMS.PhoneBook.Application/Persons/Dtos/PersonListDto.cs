using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Extensions;
using YoYoCMS.PhoneBook.Persons;

namespace YoYoCMS.PhoneBook.Persons.Dtos
{
	/// <summary>
    /// 联系人列表Dto
    /// </summary>
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto : EntityDto<int>
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public      string Name { get; set; }
        /// <summary>
        /// 邮箱地址
        /// </summary>
        public      string EmailAddress { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public      DateTime CreationTime { get; set; }
    }
}
