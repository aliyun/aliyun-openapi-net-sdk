using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliyun.Acs.Core.Regions.Location
{
    class LocationConfig
    {
        private String regionId = "cn-hangzhou";
        private String product = "Location";
        private String endpoint = "location.aliyuncs.com";

        public LocationConfig() { }

        public LocationConfig(String regionId, String product, String endpoint)
        {
            this.regionId = regionId;
            this.product = product;
            this.endpoint = endpoint;
        }

        public static LocationConfig createLocationConfig(String regionId, String product, String endpoint)
        {
            return new LocationConfig(regionId, product, endpoint);
        }

        public String RegionId
        {
            get
            {
                return regionId;
            }
            set
            {
                regionId = value;
            }
        }

        public String Product
        {
            get
            {
                return product;
            }
            set
            {
                product = value;
            }
        }

        public String Endpoint
        {
            get
            {
                return endpoint;
            }
            set
            {
                endpoint = value;
            }
        }
    }
}
