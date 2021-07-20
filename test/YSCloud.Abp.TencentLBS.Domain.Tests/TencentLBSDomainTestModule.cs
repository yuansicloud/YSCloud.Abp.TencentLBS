using YSCloud.Abp.TencentLBS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace YSCloud.Abp.TencentLBS
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(TencentLBSEntityFrameworkCoreTestModule)
        )]
    public class TencentLBSDomainTestModule : AbpModule
    {
        
    }
}
