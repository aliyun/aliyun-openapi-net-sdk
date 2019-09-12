using System.Collections.Generic;

namespace Aliyun.Acs.Core.Regions
{
    public static class EndpointUserConfig
    {
        public static Dictionary<string, ProductDomain> endpoints = new Dictionary<string, ProductDomain>() { };

        public static void AddEndpoint(string product, string regionId, string domain)
        {
            if (product == null || regionId == null || domain == null)
            {
                return;
            }
            string key = product + "_" + regionId;
            if (!endpoints.ContainsKey(key))
            {
                ProductDomain productDomain = new ProductDomain(product, domain);
                endpoints.Add(key, productDomain);
            }
        }

        public static ProductDomain GetProductDomain(string product, string regionId)
        {
            string key = product + "_" + regionId;
            ProductDomain productDomain = null;
            if (endpoints.ContainsKey(key))
            {
                productDomain = endpoints[key];
            }
            return productDomain;
        }

        public static void Clear(){
            endpoints = new Dictionary<string, ProductDomain>(){};
        }
    }
}
