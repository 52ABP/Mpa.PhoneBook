using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace YoYoCMS.PhoneBook.Dto
{
    public class PagedAndSortedInputDto : IPagedResultRequest, ISortedResultRequest
    {
        public string Sorting { get; set; }

        public PagedAndSortedInputDto()
        {
            MaxResultCount = PhoneBookConsts.DefaultPageSize;
        }

        [Range(1, PhoneBookConsts.MaxPageSize)]
        public int MaxResultCount { get; set; }

        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }

       
    }
}