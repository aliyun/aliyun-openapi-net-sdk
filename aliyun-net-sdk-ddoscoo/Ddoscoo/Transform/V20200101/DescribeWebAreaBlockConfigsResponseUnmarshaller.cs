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
    public class DescribeWebAreaBlockConfigsResponseUnmarshaller
    {
        public static DescribeWebAreaBlockConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWebAreaBlockConfigsResponse describeWebAreaBlockConfigsResponse = new DescribeWebAreaBlockConfigsResponse();

			describeWebAreaBlockConfigsResponse.HttpResponse = _ctx.HttpResponse;
			describeWebAreaBlockConfigsResponse.RequestId = _ctx.StringValue("DescribeWebAreaBlockConfigs.RequestId");

			List<DescribeWebAreaBlockConfigsResponse.DescribeWebAreaBlockConfigs_AreaBlockConfig> describeWebAreaBlockConfigsResponse_areaBlockConfigs = new List<DescribeWebAreaBlockConfigsResponse.DescribeWebAreaBlockConfigs_AreaBlockConfig>();
			for (int i = 0; i < _ctx.Length("DescribeWebAreaBlockConfigs.AreaBlockConfigs.Length"); i++) {
				DescribeWebAreaBlockConfigsResponse.DescribeWebAreaBlockConfigs_AreaBlockConfig areaBlockConfig = new DescribeWebAreaBlockConfigsResponse.DescribeWebAreaBlockConfigs_AreaBlockConfig();
				areaBlockConfig.Domain = _ctx.StringValue("DescribeWebAreaBlockConfigs.AreaBlockConfigs["+ i +"].Domain");

				List<DescribeWebAreaBlockConfigsResponse.DescribeWebAreaBlockConfigs_AreaBlockConfig.DescribeWebAreaBlockConfigs_Region> areaBlockConfig_regionList = new List<DescribeWebAreaBlockConfigsResponse.DescribeWebAreaBlockConfigs_AreaBlockConfig.DescribeWebAreaBlockConfigs_Region>();
				for (int j = 0; j < _ctx.Length("DescribeWebAreaBlockConfigs.AreaBlockConfigs["+ i +"].RegionList.Length"); j++) {
					DescribeWebAreaBlockConfigsResponse.DescribeWebAreaBlockConfigs_AreaBlockConfig.DescribeWebAreaBlockConfigs_Region region = new DescribeWebAreaBlockConfigsResponse.DescribeWebAreaBlockConfigs_AreaBlockConfig.DescribeWebAreaBlockConfigs_Region();
					region.Block = _ctx.IntegerValue("DescribeWebAreaBlockConfigs.AreaBlockConfigs["+ i +"].RegionList["+ j +"].Block");
					region.Region = _ctx.StringValue("DescribeWebAreaBlockConfigs.AreaBlockConfigs["+ i +"].RegionList["+ j +"].Region");

					areaBlockConfig_regionList.Add(region);
				}
				areaBlockConfig.RegionList = areaBlockConfig_regionList;

				describeWebAreaBlockConfigsResponse_areaBlockConfigs.Add(areaBlockConfig);
			}
			describeWebAreaBlockConfigsResponse.AreaBlockConfigs = describeWebAreaBlockConfigsResponse_areaBlockConfigs;
        
			return describeWebAreaBlockConfigsResponse;
        }
    }
}
