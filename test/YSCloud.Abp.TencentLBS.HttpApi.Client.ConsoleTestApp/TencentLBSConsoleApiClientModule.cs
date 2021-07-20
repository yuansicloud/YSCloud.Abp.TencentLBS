using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace YSCloud.Abp.TencentLBS
{
    [DependsOn(
        typeof(TencentLBSHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class TencentLBSConsoleApiClientModule : AbpModule
    {
        
    }
}
