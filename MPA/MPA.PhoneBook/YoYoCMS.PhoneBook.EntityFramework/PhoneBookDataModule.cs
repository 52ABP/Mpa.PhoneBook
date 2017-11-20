using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using YoYoCMS.PhoneBook.EntityFramework;

namespace YoYoCMS.PhoneBook
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(PhoneBookCoreModule))]
    public class PhoneBookDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<PhoneBookDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
