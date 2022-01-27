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

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeNetworkRegionBlockResponseUnmarshaller
    {
        public static DescribeNetworkRegionBlockResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNetworkRegionBlockResponse describeNetworkRegionBlockResponse = new DescribeNetworkRegionBlockResponse();

			describeNetworkRegionBlockResponse.HttpResponse = _ctx.HttpResponse;
			describeNetworkRegionBlockResponse.RequestId = _ctx.StringValue("DescribeNetworkRegionBlock.RequestId");

			DescribeNetworkRegionBlockResponse.DescribeNetworkRegionBlock_Config config = new DescribeNetworkRegionBlockResponse.DescribeNetworkRegionBlock_Config();
			config.RegionBlockSwitch = _ctx.StringValue("DescribeNetworkRegionBlock.Config.RegionBlockSwitch");

			List<string> config_countries = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeNetworkRegionBlock.Config.Countries.Length"); i++) {
				config_countries.Add(_ctx.StringValue("DescribeNetworkRegionBlock.Config.Countries["+ i +"]"));
			}
			config.Countries = config_countries;

			List<string> config_provinces = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeNetworkRegionBlock.Config.Provinces.Length"); i++) {
				config_provinces.Add(_ctx.StringValue("DescribeNetworkRegionBlock.Config.Provinces["+ i +"]"));
			}
			config.Provinces = config_provinces;
			describeNetworkRegionBlockResponse.Config = config;
        
			return describeNetworkRegionBlockResponse;
        }
    }
}
