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

using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;
using System.Linq;

namespace Aliyun.Acs.Core.Regions
{
    public class InternalEndpointsParser : IEndpointsProvider
    {
        private const string BundledEndpointsResourcePath = "endpoints.xml";

        public List<Endpoint> GetEndpoints()
        {
            var endpoints = new List<Endpoint>();

            var doc = LoadEndpointDocument();
            var endpointElements = doc.Descendants("Endpoint");
            foreach (var element in endpointElements)
            {
                var regionIds = new HashSet<string>();

                var regionIdElements = element.Descendants("RegionId");
                foreach (var regionIdElement in regionIdElements)
                    regionIds.Add(regionIdElement.Value);

                var productElements = element.Descendants("Product");
                var products = productElements.Select(productElement => new ProductDomain
                {
                    DomianName = productElement.Element("DomainName").Value, ProductName = productElement.Element("ProductName").Value
                }).ToList();

                endpoints.Add(new Endpoint(element.Attribute("name").Value, regionIds, products));
            }

            return endpoints;
        }

        private XDocument LoadEndpointDocument()
        {
            var type = GetType();

            //var assemblyQualifiedNames = type.AssemblyQualifiedName.Split(',').Skip(1).ToArray();
            //AssemblyName assemblyName = new AssemblyName(string.Join(",", assemblyQualifiedNames));

            //var assembly = Assembly.Load(assemblyName);
            var assembly = type.GetTypeInfo().Assembly;

            string resourceName = $"{type.Namespace}.{BundledEndpointsResourcePath}";
            var stream = assembly.GetManifestResourceStream(resourceName);
            var xmlDoc = XDocument.Load(stream);

            return xmlDoc;
        }
    }
}