using YSCloud.Abp.TencentLBS.Models;

namespace YSCloud.Abp.TencentLBS.Geocoder
{
    public class GeocodingResponse
    {
        public string Title { get; set; }

        public GeoLocation Location { get; set; }

        public GeocodingAddressInfo Ad_Info { get; set; }

        public GeocodingAddressComponents Address_Components { get; set; }

        public int Reliability { get; set; }

        public int Level { get; set; }
    }

    public class GeocodingAddressInfo
    {
        public string Adcode { get; set; }
    }

    public class GeocodingAddressComponents
    {
        public string Province { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string Street { get; set; }

        public string Street_Number { get; set; }
    }
}