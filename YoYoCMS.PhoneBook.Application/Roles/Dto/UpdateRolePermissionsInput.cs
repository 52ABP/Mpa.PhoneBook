using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace YoYoCMS.PhoneBook.Roles.Dto
{
    /// <summary>
    /// 修改角色权限信息接收的DTO
    /// </summary>
    public class UpdateRolePermissionsInput : IInputDto
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        [Range(1, int.MaxValue)]
        public int RoleId { get; set; }
        /// <summary>
        /// 获取权限名称列表
        /// </summary>
        [Required]
        public List<string> GrantedPermissionNames { get; set; }
    }
}