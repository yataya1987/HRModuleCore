using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using HRCoreModule.EntityFramework;

namespace HRCoreModule.Migrator
{
    [DependsOn(typeof(HRCoreModuleDataModule))]
    public class HRCoreModuleMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<HRCoreModuleDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}