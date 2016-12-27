using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace YoYoCMS.PhoneBook.Users.Dto
{
    public class ProhibitPermissionInput 
    {
        [Range(1, long.MaxValue)]
        public int UserId { get; set; }

        [Required]
        public string PermissionName { get; set; }
    }
}