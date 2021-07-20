using Volo.Abp.Modularity;

namespace YSCloud.Abp.TencentLBS
{
    [DependsOn(
        typeof(TencentLBSApplicationModule),
        typeof(TencentLBSDomainTestModule)
        )]
    public class TencentLBSApplicationTestModule : AbpModule
    {

    }
}
