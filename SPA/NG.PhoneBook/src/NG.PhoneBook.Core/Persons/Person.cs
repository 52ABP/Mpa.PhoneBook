using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using NG.PhoneBook.Phones;

namespace NG.PhoneBook.Persons
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