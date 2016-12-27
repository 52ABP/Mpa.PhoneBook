using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using YoYoCMS.PhoneBook.Authorization.Roles;
using YoYoCMS.PhoneBook.Editions;
using YoYoCMS.PhoneBook.Users;

namespace YoYoCMS.PhoneBook.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant,  User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore
            ) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore
            )
        {
        }
    }
}