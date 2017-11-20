using System.Linq;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.MultiTenancy;
using YoYoCMS.PhoneBook.Authorization;
using YoYoCMS.PhoneBook.Authorization.Roles;
using YoYoCMS.PhoneBook.EntityFramework;
using YoYoCMS.PhoneBook.Users;
using Microsoft.AspNet.Identity;
using YoYoCMS.PhoneBook.Persons.Authorization;

namespace YoYoCMS.PhoneBook.Migrations.SeedData
{
    public class HostRoleAndUserCreator
    {
        private readonly PhoneBookDbContext _context;

        public HostRoleAndUserCreator(PhoneBookDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateHostRoleAndUsers();
        }

        private void CreateHostRoleAndUsers()
        {
            //Admin role for host

            var adminRoleForHost = _context.Roles.FirstOrDefault(r => r.TenantId == null && r.Name == StaticRoleNames.Host.Admin);
            if (adminRoleForHost == null)
            {
                adminRoleForHost = _context.Roles.Add(new Role { Name = StaticRoleNames.Host.Admin, DisplayName = StaticRoleNames.Host.Admin, IsStatic = true });
                _context.SaveChanges();

                //Grant all tenant permissions
                var permissions = PermissionFinder
                    .GetAllPermissions(new PhoneBookAuthorizationProvider())
                    .Where(p => p.MultiTenancySides.HasFlag(MultiTenancySides.Host))
                    .ToList();
                var personPermissions =
                 PermissionFinder.GetAllPermissions(new PersonAppAuthorizationProvider()).ToList();
                permissions.AddRange(personPermissions);
                foreach (var permission in permissions)
                {
                  
                        _context.Permissions.Add(
                            new RolePermissionSetting
                            {
                                Name = permission.Name,
                                IsGranted = true,
                                RoleId = adminRoleForHost.Id
                            });
    
                }

                _context.SaveChanges();
            }

            //Admin user for tenancy host

            var adminUserForHost = _context.Users.FirstOrDefault(u => u.TenantId == null && u.UserName == User.AdminUserName);
            if (adminUserForHost == null)
            {
                adminUserForHost = _context.Users.Add(
                    new User
                    {
                        UserName = User.AdminUserName,
                        Name = "System",
                        Surname = "Administrator",
                        EmailAddress = "admin@aspnetboilerplate.com",
                        IsEmailConfirmed = true,
                        Password = new PasswordHasher().HashPassword(User.DefaultPassword)
                    });

                _context.SaveChanges();

                _context.UserRoles.Add(new UserRole(null, adminUserForHost.Id, adminRoleForHost.Id));

                _context.SaveChanges();
            }
        }
    }
}