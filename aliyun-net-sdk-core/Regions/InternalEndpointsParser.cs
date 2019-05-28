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
using System.Runtime.CompilerServices;
using System.Xml;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Regions.Location;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace Aliyun.Acs.Core.Regions
{
    internal class InternalEndpointsParser : IEndpointsProvider
    {
        private const string BUNDLED_ENDPOINTS_RESOURCE_PATH = "endpoints.xml";

        public Endpoint GetEndpoint(string region, string product)
        {
            var allProducts = GetProducts();

            ISet<string> regionSet = new HashSet<string>();
            var productDomains = new List<ProductDomain>();
            foreach (var p in allProducts)
            {
                if (!string.Equals(product, p.Code, StringComparison.InvariantCultureIgnoreCase))
                {
                    continue;
                }

                foreach (var e in p.RegionalEndpoints)
                {
                    if (!string.Equals(region, e.Key, StringComparison.InvariantCultureIgnoreCase))
                    {
                        continue;
                    }

                    regionSet.Add(region);

                    var productDomain = new ProductDomain();
                    productDomain.ProductName = product;
                    productDomain.DomianName = e.Value;
                    productDomains.Add(productDomain);
                }

                if (regionSet.Count == 0)
                {
                    if (string.IsNullOrEmpty(p.GlobalEndpoint))
                    {
                        return null;
                    }

                    regionSet.Add(region);

                    var productDomain = new ProductDomain();
                    productDomain.ProductName = product;
                    productDomain.DomianName = p.GlobalEndpoint;
                    productDomains.Add(productDomain);
                }

                break;
            }

            return new Endpoint(region, regionSet, productDomains);
        }

        public Endpoint GetEndpoint(string region, string product, string serviceCode, string endpointType,
            Credential credential, LocationConfig locationConfig)
        {
            throw new NotSupportedException();
        }

        private static List<Product> ParseProducts(Stream stream)
        {
            var doc = new XmlDocument();
            doc.Load(stream);
            using (var productNodes = doc.GetElementsByTagName("product"))
            {
                var products = new List<Product>();
                foreach (XmlNode node in productNodes)
                {
                    var product = new Product();
                    product.Code = node.SelectSingleNode("code").InnerText;
                    product.LocationServiceCode = node.SelectSingleNode("location_service_code").InnerText;
                    product.DocumentId = node.SelectSingleNode("document_id").InnerText;

                    product.RegionalEndpoints = new Dictionary<string, string>();
                    using (var regional_endpoints =
                        node.SelectSingleNode("regional_endpoints").SelectNodes("regional_endpoint"))
                    {
                        foreach (XmlNode regionalNode in regional_endpoints)
                        {
                            product.RegionalEndpoints.Add(regionalNode.SelectSingleNode("region_id").InnerText,
                                regionalNode.SelectSingleNode("endpoint").InnerText);
                        }

                        product.GlobalEndpoint = node.SelectSingleNode("global_endpoint").InnerText;
                        product.RegionalEndpointPattern = node.SelectSingleNode("regional_endpoint_pattern").InnerText;
                        products.Add(product);
                    }
                }

                return products;
            }
        }

        public virtual List<Product> GetProducts()
        {
            var type = MethodBase.GetCurrentMethod().DeclaringType;
            var _namespace = type.Namespace;
            var _assembly = Assembly.GetExecutingAssembly();
            var resourceName = _namespace + "." + BUNDLED_ENDPOINTS_RESOURCE_PATH;
            using (var stream = _assembly.GetManifestResourceStream(resourceName))
            {
                return ParseProducts(stream);
            }
        }

        public class Product
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
