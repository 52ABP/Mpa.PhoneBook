using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace NG.PhoneBook.EntityFramework.Repositories
{
    public abstract class PhoneBookRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<PhoneBookDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected PhoneBookRepositoryBase(IDbContextProvider<PhoneBookDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class PhoneBookRepositoryBase<TEntity> : PhoneBookRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected PhoneBookRepositoryBase(IDbContextProvider<PhoneBookDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
