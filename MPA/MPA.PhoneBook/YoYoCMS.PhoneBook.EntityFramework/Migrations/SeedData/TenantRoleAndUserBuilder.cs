using System.Linq;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.MultiTenancy;
using YoYoCMS.PhoneBook.Authorization;
using YoYoCMS.PhoneBook.Authorization.Roles;
using YoYoCMS.PhoneBook.EntityFramework;
using YoYoCMS.PhoneBook.Persons.Authorization;
using YoYoCMS.PhoneBook.Users;

namespace YoYoCMS.PhoneBook.Migrations.SeedData
{
    public class TenantRoleAndUserBuilder
    {
        private readonly PhoneBookDbContext _context;
        private readonly int _tenantId;

        public TenantRoleAndUserBuilder(PhoneBookDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            CreateRolesAndUsers();
        }

        private void CreateRolesAndUsers()
        {
            //Admin role

            var adminRole = _context.Roles.FirstOrDefault(r => r.TenantId == _tenantId && r.Name == StaticRoleNames.Tenants.Admin);
            if (adminRole == null)
            {
                adminRole = _context.Roles.Add(new Role(_tenantId, StaticRoleNames.Tenants.Admin, StaticRoleNames.Tenants.Admin) { IsStatic = true });
                _context.SaveChanges();

                //Grant all permissions to admin role
                var permissions = PermissionFinder
                    .GetAllPermissions(new PhoneBookAuthorizationProvider())
                    .Where(p => p.MultiTenancySides.HasFlag(MultiTenancySides.Tenant))
                    .ToList();
                var personPermissions =
                 PermissionFinder.GetAllPermissions(new PersonAppAuthorizationProvider()).ToList();
                permissions.AddRange(personPermissions);
                foreach (var permission in permissions)
                {
         
                        _context.Permissions.Add(
                            new RolePermissionSetting
                            {
                                TenantId = _tenantId,
                                Name = permission.Name,
                                IsGranted = true,
                                RoleId = adminRole.Id
                            });
                    }
 

                _context.SaveChanges();
            }

            //admin user

            var adminUser = _context.Users.FirstOrDefault(u => u.TenantId == _tenantId && u.UserName == User.AdminUserName);
            if (adminUser == null)
            {
                adminUser = User.CreateTenantAdminUser(_tenantId, "admin@defaulttenant.com", "123qwe");
                adminUser.IsEmailConfirmed = true;
                adminUser.IsActive = true;

                _context.Users.Add(adminUser);
                _context.SaveChanges();

                //Assign Admin role to admin user
                _context.UserRoles.Add(new UserRole(_tenantId, adminUser.Id, adminRole.Id));
                _context.SaveChanges();
            }
        }
    }
}