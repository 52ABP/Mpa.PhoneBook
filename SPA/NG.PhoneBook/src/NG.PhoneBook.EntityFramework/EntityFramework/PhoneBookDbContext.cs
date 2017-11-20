using System.Data.Common;
using Abp.Zero.EntityFramework;
using NG.PhoneBook.Authorization.Roles;
using NG.PhoneBook.Authorization.Users;
using NG.PhoneBook.MultiTenancy;

namespace NG.PhoneBook.EntityFramework
{
    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

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
        public PhoneBookDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public PhoneBookDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
