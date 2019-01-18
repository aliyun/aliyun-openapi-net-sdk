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
