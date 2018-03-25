using System;
using Abp.Application.Services.Dto;
using Abp.Extensions;
using Abp.Runtime.Validation;
using YoYoCMS.PhoneBook.Dto;
using YoYoCMS.PhoneBook.Persons.Dtos;
using YoYoCMS.PhoneBook.Persons;

namespace YoYoCMS.PhoneBook.Persons.Dtos
{
	/// <summary>
	/// 联系人查询Dto
	/// </summary>
	public class GetPersonInput : PagedAndSortedInputDto, IShouldNormalize
	{
		//DOTO:在这里增加查询参数

		/// <summary>
		/// 模糊查询参数
		/// </summary>
		public string FilterText { get; set; }

		/// <summary>
		/// 用于排序的默认值
		/// </summary>
		public void Normalize()
		{
			if (string.IsNullOrEmpty(Sorting))
			{
			
		
				Sorting = "Id";
			}
		}
	}
}
