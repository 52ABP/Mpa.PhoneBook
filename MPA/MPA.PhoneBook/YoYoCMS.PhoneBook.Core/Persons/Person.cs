using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using YoYoCMS.PhoneBook.Phones;

namespace YoYoCMS.PhoneBook.Persons
{
    /// <summary>
    /// 联系人
    /// </summary>
    public class Person : FullAuditedEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(PhoneBookConsts.MaxNameLength)]
        public virtual string Name { get; set; }


        /// <summary>
        /// 邮箱地址
        /// </summary>
        [MaxLength(PhoneBookConsts.MaxEmailAddressLength)]
        public virtual string EmailAddress { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }

    }
}