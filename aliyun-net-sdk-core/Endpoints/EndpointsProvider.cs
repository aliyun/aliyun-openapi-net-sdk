using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Regions.Location.Model;
using Aliyun.Acs.Core.Utils;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Aliyun.Acs.Core.Endpoints
{
    public class EndpointsDataProvider
    {
        private const string BUNDLED_ENDPOINTS_RESOURCE_PATH = "endpoints.json";

        private static Dictionary<string, Endpoint> endpoints;
        private static Dictionary<string, Dictionary<string, string>> regionListDictionary;

        public static Endpoint GetEndpoint(string product, string regionId, string serviceCode)
        {
            if (null == endpoints)
            {
                endpoints = new Dictionary<string, Endpoint>();
            }
            if (0 <= endpoints.Count)
            {
                InitEndpointsData();
            }

            string index = $"{product}_{regionId}";
            endpoints.TryGetValue(index, out Endpoint endpoint);

            return endpoint;
        }

        private static string GetRegionIdList(string product)
        {
            var regionIdList = DictionaryUtil.Get(regionListDictionary, product);
            return DictionaryUtil.TransformDicToString(regionIdList);
        }

        private static void InitEndpointsData()
        {
            Type type = MethodBase.GetCurrentMethod().DeclaringType;
            string _namespace = type.Namespace;
            Assembly _assembly = Assembly.GetExecutingAssembly();
            string resourceName = _namespace + "." + BUNDLED_ENDPOINTS_RESOURCE_PATH;

            Stream stream = _assembly.GetManifestResourceStream(resourceName);

            using(StreamReader r = new StreamReader(stream))
            {
                var json = r.ReadToEnd();
                var job = JObject.Parse(json);
                foreach (var item in job.Properties())
                {
                    var product = item.Name;
                    var regionList = new Dictionary<string, string>();

                    foreach (var productItem in item.Value)
                    {
                        var domain = (string) ((JValue) ((JProperty) productItem).Value).Value;
                        var regionId = ((JProperty) (productItem)).Name;
                        InitialEndpointList(product, regionId, domain);
                        DictionaryUtil.Add(regionList, regionId, domain);
                    }

                    InitialRegionList(product, regionList);
                }
            }
        }

        private static void InitialEndpointList(string product, string regionId, string domain)
        {
            var endpoint = new Endpoint(product, regionId, domain);
            DictionaryUtil.Add(endpoints, product + "_" + regionId, endpoint);
        }

        private static void InitialRegionList(string product, Dictionary<string, string> regionList)
        {
            DictionaryUtil.Add(regionListDictionary, product, regionList);
        }
    }
}
