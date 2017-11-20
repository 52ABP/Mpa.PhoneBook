using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using NG.PhoneBook.Persons;

namespace NG.PhoneBook.Phones
{
    /// <summary>
    ///     电话本实体信息
    /// </summary>
    [Table("PbPhone")]
    public class Phone : CreationAuditedEntity<long>
    {
        public const int MaxNumberLength = 16;

        /// <summary>
        ///     联系人id
        /// </summary>
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }

        public virtual int PersonId { get; set; }

        /// <summary>
        ///     电话类型
        /// </summary>
        [Required]
        public virtual PhoneType Type { get; set; }

        /// <summary>
        ///     联系号码
        /// </summary>
        [Required]
        [MaxLength(MaxNumberLength)]
        public virtual string Number { get; set; }

    }
}