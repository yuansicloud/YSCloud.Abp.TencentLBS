using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Settings;
using YSCloud.Abp.TencentLBS.Settings;
using YSCloud.TencentLBS.Common.Geocoder;

namespace YSCloud.Abp.TencentLBS.Geocoder
{
    public class GeocoderApiRequester : ITransientDependency
    {
        private readonly ISettingProvider _settingProvider;

        private readonly GeocoderAPI _geocoderAPI;

        public GeocoderApiRequester(ISettingProvider settingProvider, IOptions<AbpTencentLBSCommonOptions> options)
        {
            _settingProvider = settingProvider;
            _geocoderAPI = RestService.For<GeocoderAPI>(options.Value.EndPoint,
            new RefitSettings
            {
                ContentSerializer = new NewtonsoftJsonContentSerializer(
                    new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    }
                )
            });
        }

        public async Task<GeocodingResponse> Geocoding(GeocodingRequest request)
        {
            var key = await _settingProvider.GetOrNullAsync(AbpTencentLBSSettings.DefaultKey);

            var response = await _geocoderAPI.Geocoding(key, request);

            response.CheckStatus();

            return response.Result;
        }
    }
}