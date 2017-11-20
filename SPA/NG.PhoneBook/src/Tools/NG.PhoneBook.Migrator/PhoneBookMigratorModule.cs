using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using NG.PhoneBook.EntityFramework;

namespace NG.PhoneBook.Migrator
{
    [DependsOn(typeof(PhoneBookDataModule))]
    public class PhoneBookMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<PhoneBookDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}