/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Regions.Location;

using Newtonsoft.Json.Linq;

namespace Aliyun.Acs.Core.Regions
{
    internal class InternalEndpointsParser : IEndpointsProvider
    {
        private const string LocalEndpointResourcePath = "endpoints.json";
        private readonly IDictionary<string, string> globalEndpointCollection;

        private readonly JObject jObject;
        private readonly IDictionary<string, string> regionIdEndpointCollection;

        public InternalEndpointsParser()
        {
            regionIdEndpointCollection = new Dictionary<string, string>();
            globalEndpointCollection = new Dictionary<string, string>();

            if (jObject == null)
            {
                try
                {
                    var currentNamespace = MethodBase.GetCurrentMethod().DeclaringType.Namespace;
                    var localAssembly = Assembly.GetExecutingAssembly();

                    var resourceName = currentNamespace + "." + LocalEndpointResourcePath;

                    using (var stream = localAssembly.GetManifestResourceStream(resourceName))
                    using (var streamReader = new StreamReader(stream))
                    {
                        var data = streamReader.ReadToEnd();
                        jObject = JObject.Parse(data);
                    }

                    var globalEndpoint = (JObject)jObject["global_endpoints"];
                    var regionalEndpoint = (JObject)jObject["regional_endpoints"];

                    foreach (var pair in globalEndpoint.Properties())
                    {
                        var productName = pair.Name;
                        var domain = pair.Value.ToString();

                        if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(domain))
                        {
                            continue;
                        }

                        globalEndpointCollection.Add(productName, domain);
                    }

                    foreach (var pair in regionalEndpoint.Properties())
                    {
                        var productName = pair.Name;
                        foreach (JProperty regionAndValue in pair.Value)
                        {
                            var regionId = regionAndValue.Name;
                            var domain = regionAndValue.Value.ToString();

                            if (string.IsNullOrEmpty(productName) ||
                                string.IsNullOrEmpty(regionId) ||
                                string.IsNullOrEmpty(domain))
                            {
                                continue;
                            }

                            regionIdEndpointCollection.Add(productName + "_" + regionId, domain);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new ClientException("LoadEndpointFileToCollection Fail:", e.ToString());
                }
            }
        }

        public Endpoint GetEndpoint(string regionId, string productName)
        {
            string domain;

            regionIdEndpointCollection.TryGetValue(string.Format("{0}_{1}", productName.ToLower(), regionId), out domain);

            if (string.IsNullOrEmpty(domain))
            {
                globalEndpointCollection.TryGetValue(productName.ToLower(), out domain);
            }

            if (string.IsNullOrEmpty(domain))
            {
                return null;
            }

            var regionHashset = new HashSet<string> {regionId};
            var productDomain = new List<ProductDomain> {new ProductDomain(productName, domain)};

            return new Endpoint(productName, regionHashset, productDomain);
        }

        public Endpoint GetEndpoint(string region, string product, string serviceCode, string endpointType,
            Credential credential, LocationConfig locationConfig)
        {
            throw new NotSupportedException();
        }

        internal class Product
        {
            public string Code { get; set; }
            public string LocationServiceCode { get; set; }
            public string DocumentId { get; set; }
            public Dictionary<string, string> RegionalEndpoints { get; set; }
            public string GlobalEndpoint { get; set; }
            public string RegionalEndpointPattern { get; set; }
        }
    }
}
