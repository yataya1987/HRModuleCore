using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using HRCoreModule.EntityFramework;

namespace HRCoreModule
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(HRCoreModuleCoreModule))]
    public class HRCoreModuleDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<HRCoreModuleDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
