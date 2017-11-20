using System.Linq;
using NG.PhoneBook.EntityFramework;
using NG.PhoneBook.MultiTenancy;

namespace NG.PhoneBook.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly PhoneBookDbContext _context;

        public DefaultTenantCreator(PhoneBookDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
