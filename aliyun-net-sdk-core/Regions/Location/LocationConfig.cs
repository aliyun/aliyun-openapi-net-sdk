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

namespace Aliyun.Acs.Core.Regions.Location
{
    class LocationConfig
    {
        public LocationConfig() { }

        public LocationConfig(string regionId, string product, string endpoint)
        {
            RegionId = regionId;
            Product = product;
            Endpoint = endpoint;
        }

        public static LocationConfig createLocationConfig(string regionId, string product, string endpoint)
        {
            return new LocationConfig(regionId, product, endpoint);
        }

        private string regionId = "cn-hangzhou";
        public string RegionId
        {
            get { return regionId; }
            set { regionId = value; }
        }

        private string product = "Location";
        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        private string endpoint = "location.aliyuncs.com";

        public string Endpoint
        {
            get { return endpoint; }
            set { endpoint = value; }
        }
    }
}
