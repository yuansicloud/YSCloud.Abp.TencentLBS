﻿using Refit;
using System.Threading.Tasks;
using YSCloud.Abp.TencentLBS.Models;
using YSCloud.TencentLBS.Common.Geocoder;

namespace YSCloud.Abp.TencentLBS.Geocoder
{
    public interface GeocoderAPI
    {
        [Get("/ws/geocoder/v1/?key={key}")]
        Task<CommonResponse<GeocodingResponse>> Geocoding([AliasAs("key")] string key, GeocodingRequest request);
    }
}