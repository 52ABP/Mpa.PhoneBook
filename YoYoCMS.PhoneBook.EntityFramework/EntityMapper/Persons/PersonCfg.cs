using System.Data.Entity.ModelConfiguration;
using YoYoCMS.PhoneBook.Persons;

namespace YoYoCMS.PhoneBook.EntityMapper.Persons
{
    public class PersonCfg : EntityTypeConfiguration<Person>
    {
		public PersonCfg ()
		{
		            ToTable("Person", YoYoCMSConsts.SchemaName.Basic);
 
      //todo: 需要将以下文件注入到YoYoCMS.PhoneBook.PersonsDbContext中

   




		    // 姓名
			Property(a => a.Name).HasMaxLength(32);
		    // 邮箱地址
			Property(a => a.EmailAddress).HasMaxLength(255);
		}
    }
}