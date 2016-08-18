using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using YoYoCMS.PhoneBook.Persons.Authorization;

namespace YoYoCMS.PhoneBook
{
    [DependsOn(typeof(PhoneBookCoreModule), typeof(AbpAutoMapperModule))]
    public class PhoneBookApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Configuration.Authorization.Providers.Add<PersonAppAuthorizationProvider>();
        }
    }
}
