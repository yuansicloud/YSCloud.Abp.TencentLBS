using Refit;
using System.Threading.Tasks;
using YSCloud.Abp.TencentLBS.Models;
using YSCloud.TencentLBS.Common.Geocoder;

namespace YSCloud.Abp.TencentLBS.Geocoder
{
    public interface GeocoderAPI
    {
        [Get("/ws/geocoder/v1/?key={key}&address={address}")]
        Task<CommonResponse<GeocodingResponse>> Geocoding([AliasAs("key")] string key, [AliasAs("address")] string address);
    }
}