using System.Linq;
using HRCoreModule.EntityFramework;
using HRCoreModule.MultiTenancy;

namespace HRCoreModule.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly HRCoreModuleDbContext _context;

        public DefaultTenantCreator(HRCoreModuleDbContext context)
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
