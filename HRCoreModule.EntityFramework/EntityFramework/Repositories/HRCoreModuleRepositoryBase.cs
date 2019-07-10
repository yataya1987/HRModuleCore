using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace HRCoreModule.EntityFramework.Repositories
{
    public abstract class HRCoreModuleRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<HRCoreModuleDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected HRCoreModuleRepositoryBase(IDbContextProvider<HRCoreModuleDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class HRCoreModuleRepositoryBase<TEntity> : HRCoreModuleRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected HRCoreModuleRepositoryBase(IDbContextProvider<HRCoreModuleDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
