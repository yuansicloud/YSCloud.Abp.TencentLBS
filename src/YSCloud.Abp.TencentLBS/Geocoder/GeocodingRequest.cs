using Refit;

namespace YSCloud.TencentLBS.Common.Geocoder
{
    public class GeocodingRequest 
    {

        [AliasAs("address")]
        public string Address { get; set; }

        [AliasAs("region")]
        public string Region { get; set; }

        public GeocodingRequest(
            string address,
            string region = null)
        {
            Address = address;

            Region = region;
        }
    }
}