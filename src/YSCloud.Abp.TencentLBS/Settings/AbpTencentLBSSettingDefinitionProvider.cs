using Microsoft.Extensions.Options;
using Volo.Abp.Localization;
using Volo.Abp.Settings;
using YSCloud.Abp.TencentLBS.Localization;

namespace YSCloud.Abp.TencentLBS.Settings
{
    public class AbpTencentLBSSettingDefinitionProvider : SettingDefinitionProvider
    {
        private readonly AbpTencentLBSCommonOptions _commonOptions;

        public AbpTencentLBSSettingDefinitionProvider(
            IOptions<AbpTencentLBSCommonOptions> commonOptions)
        {
            _commonOptions = commonOptions.Value;
        }

        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(DenturePlusSettings.MySetting1));

            context.Add(new SettingDefinition(
                AbpTencentLBSSettings.EndPoint,
                _commonOptions.EndPoint,
                L("EndPoint")));

            context.Add(new SettingDefinition(
                AbpTencentLBSSettings.DefaultKey,
                _commonOptions.Key,
                L("DefaultKey")));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpTencentLBSResource>(name);
        }
    }
}