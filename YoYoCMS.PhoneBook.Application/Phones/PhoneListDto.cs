using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;

namespace YoYoCMS.PhoneBook.Phones
{
    [AutoMapFrom(typeof (Phone))]
    public class PhoneListDto : CreationAuditedEntity<long>
    {
        /// <summary>
        ///     电话类型
        /// </summary>
        public virtual PhoneType Type { get; set; }

        /// <summary>
        ///     联系号码
        /// </summary>
        public virtual string Number { get; set; }
    }
}