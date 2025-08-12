using System;
using System.Threading.Tasks;
using Abp.TestBase;
using ABPAPISimple.EntityFrameworkCore;
using ABPAPISimple.Tests.TestDatas;

namespace ABPAPISimple.Tests
{
    public class ABPAPISimpleTestBase : AbpIntegratedTestBase<ABPAPISimpleTestModule>
    {
        public ABPAPISimpleTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<ABPAPISimpleDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<ABPAPISimpleDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<ABPAPISimpleDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<ABPAPISimpleDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<ABPAPISimpleDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<ABPAPISimpleDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<ABPAPISimpleDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<ABPAPISimpleDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
