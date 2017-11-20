using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using NG.PhoneBook.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace NG.PhoneBook.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<PhoneBook.EntityFramework.PhoneBookDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PhoneBook";
        }

        protected override void Seed(PhoneBook.EntityFramework.PhoneBookDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
