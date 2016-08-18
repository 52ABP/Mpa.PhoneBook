using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using YoYoCMS.PhoneBook.Authorization.Roles;
using YoYoCMS.PhoneBook.EntityMapper.Persons;
using YoYoCMS.PhoneBook.MultiTenancy;
using YoYoCMS.PhoneBook.Persons;
using YoYoCMS.PhoneBook.Users;

namespace YoYoCMS.PhoneBook.EntityFramework
{
    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        public IDbSet<Person> Persons { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public PhoneBookDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in PhoneBookDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of PhoneBookDbContext since ABP automatically handles it.
         */
        public PhoneBookDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public PhoneBookDbContext(DbConnection connection)
            : base(connection, true)
        {
 
        }

        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonCfg());
            base.OnModelCreating(modelBuilder);
         }
    }
}
