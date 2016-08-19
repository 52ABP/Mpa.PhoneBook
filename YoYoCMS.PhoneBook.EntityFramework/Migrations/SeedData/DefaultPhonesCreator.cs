using System.Collections.Generic;
using System.Linq;
using YoYoCMS.PhoneBook.EntityFramework;
using YoYoCMS.PhoneBook.Persons;
using YoYoCMS.PhoneBook.Phones;

namespace YoYoCMS.PhoneBook.Migrations.SeedData
{

    /// <summary>
    /// 默认电话信息的添加
    /// </summary>
    public class DefaultPhonesCreator
    {
        private readonly PhoneBookDbContext _context;

        public DefaultPhonesCreator(PhoneBookDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreatePhone();
        }


        private void CreatePhone()
        {
            var defaultPhone = _context.Persons.FirstOrDefault(p => p.EmailAddress == "admin@yoyocms.com");
            if (defaultPhone==null)
            {
                _context.Persons.Add(new Person()
                {
                    Name = "张三",
                    EmailAddress = "admin@yoyocms.com",
                    Phones = new List<Phone>()
                    {
                        new Phone() {Type = PhoneType.Business,Number = "87115555"},
                        new Phone() {Type = PhoneType.Home,Number = "010-1109"}
                    }
                });
            }
            var defaultPerson = _context.Persons.FirstOrDefault(p => p.EmailAddress == "lisi@yoyocms.com");
            if (defaultPerson==null)
            {
                _context.Persons.Add(new Person()
                {
                    Name = "李四",
                    EmailAddress = "lisi@yoyocms.com",
                    Phones = new List<Phone>()
                    {
                          new Phone() {Type = PhoneType.Business,Number = "88452675"},
                        new Phone() {Type = PhoneType.Home,Number = "010-441109"}
                    }
                });
            }
            _context.SaveChanges();

        }

    }
}