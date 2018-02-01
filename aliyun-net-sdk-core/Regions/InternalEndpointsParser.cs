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
using System.Xml;
using System.IO;
using System.Reflection;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Regions.Location;

namespace Aliyun.Acs.Core.Regions
{
    class InternalEndpointsParser : IEndpointsProvider
    {
        private const String BUNDLED_ENDPOINTS_RESOURCE_PATH = "endpoints.xml";

        private static List<Endpoint> ParseEndpoints(Stream stream)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(stream);
            XmlNodeList endpointNodes = doc.GetElementsByTagName("Endpoint");

            List<Endpoint> endpoints = new List<Endpoint>();
            foreach (XmlNode node in endpointNodes)
            {
                HashSet<string> regionIds = new HashSet<string>();
                List<ProductDomain> products = new List<ProductDomain>();
                XmlNodeList regionIdNodes = node.SelectSingleNode("RegionIds").SelectNodes("RegionId");
                XmlNodeList productNodes = node.SelectSingleNode("Products").SelectNodes("Product");
                foreach (XmlNode regionIdNode in regionIdNodes)
                {
                    regionIds.Add(regionIdNode.InnerText);
                }
                foreach (XmlNode productNode in productNodes)
                {
                    ProductDomain productDomain = new ProductDomain();
                    productDomain.DomianName = productNode.SelectSingleNode("DomainName").InnerText;
                    productDomain.ProductName = productNode.SelectSingleNode("ProductName").InnerText;
                    products.Add(productDomain);
                }
                endpoints.Add(new Endpoint(node.Attributes["name"].InnerText, regionIds, products));
            }
            return endpoints;
        }

        public List<Endpoint> GetEndpoints()
        {
            Type type = MethodBase.GetCurrentMethod().DeclaringType;
            string _namespace = type.Namespace;
            Assembly _assembly = Assembly.GetExecutingAssembly();
            string resourceName = _namespace + "." + BUNDLED_ENDPOINTS_RESOURCE_PATH;
            Stream stream = _assembly.GetManifestResourceStream(resourceName);
            return ParseEndpoints(stream);
        }

        public Endpoint GetEndpoint(string region, string product)
        {
            List<Endpoint> internalEndpoints = GetEndpoints();
            foreach (Endpoint endpoint in internalEndpoints)
            {
                foreach (String regionId in endpoint.RegionIds)
                {
                    if (regionId.Equals(region))
                    {
                        foreach (ProductDomain productDomain in endpoint.ProductDomains)
                        {
                            if (productDomain.ProductName.Equals(product))
                            {
                                ISet<String> regionSet = new HashSet<String>();
                                regionSet.Add(region);

                                List<ProductDomain> productDomains = new List<ProductDomain>();
                                productDomains.Add(productDomain);
                                Endpoint resultEndpoint = new Endpoint(endpoint.Name, regionSet, productDomains);
                                return resultEndpoint;
                            }
                        }
                    }
                }
            }
            return null;
        }

        public Endpoint GetEndpoint(string region, string product, string serviceCode, string endpointType,
            Credential credential, LocationConfig locationConfig)
        {
            throw new NotSupportedException();
        }
    }
}