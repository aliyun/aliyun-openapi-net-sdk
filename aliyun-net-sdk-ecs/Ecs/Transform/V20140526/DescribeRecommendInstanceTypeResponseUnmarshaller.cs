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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeRecommendInstanceTypeResponseUnmarshaller
    {
        public static DescribeRecommendInstanceTypeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRecommendInstanceTypeResponse describeRecommendInstanceTypeResponse = new DescribeRecommendInstanceTypeResponse();

			describeRecommendInstanceTypeResponse.HttpResponse = context.HttpResponse;
			describeRecommendInstanceTypeResponse.RequestId = context.StringValue("DescribeRecommendInstanceType.RequestId");

			List<DescribeRecommendInstanceTypeResponse.DescribeRecommendInstanceType_RecommendInstanceType> describeRecommendInstanceTypeResponse_data = new List<DescribeRecommendInstanceTypeResponse.DescribeRecommendInstanceType_RecommendInstanceType>();
			for (int i = 0; i < context.Length("DescribeRecommendInstanceType.Data.Length"); i++) {
				DescribeRecommendInstanceTypeResponse.DescribeRecommendInstanceType_RecommendInstanceType recommendInstanceType = new DescribeRecommendInstanceTypeResponse.DescribeRecommendInstanceType_RecommendInstanceType();
				recommendInstanceType.RegionId = context.StringValue("DescribeRecommendInstanceType.Data["+ i +"].RegionId");
				recommendInstanceType.CommodityCode = context.StringValue("DescribeRecommendInstanceType.Data["+ i +"].CommodityCode");
				recommendInstanceType.Scene = context.StringValue("DescribeRecommendInstanceType.Data["+ i +"].Scene");
				recommendInstanceType.InstanceChargeType = context.StringValue("DescribeRecommendInstanceType.Data["+ i +"].InstanceChargeType");
				recommendInstanceType.SpotStrategy = context.StringValue("DescribeRecommendInstanceType.Data["+ i +"].SpotStrategy");
				recommendInstanceType.Priority = context.IntegerValue("DescribeRecommendInstanceType.Data["+ i +"].Priority");

				DescribeRecommendInstanceTypeResponse.DescribeRecommendInstanceType_RecommendInstanceType.DescribeRecommendInstanceType_InstanceType instanceType = new DescribeRecommendInstanceTypeResponse.DescribeRecommendInstanceType_RecommendInstanceType.DescribeRecommendInstanceType_InstanceType();
				instanceType.Generation = context.StringValue("DescribeRecommendInstanceType.Data["+ i +"].InstanceType.Generation");
				instanceType.InstanceTypeFamily = context.StringValue("DescribeRecommendInstanceType.Data["+ i +"].InstanceType.InstanceTypeFamily");
				instanceType.InstanceType = context.StringValue("DescribeRecommendInstanceType.Data["+ i +"].InstanceType.InstanceType");
				instanceType.SupportIoOptimized = context.StringValue("DescribeRecommendInstanceType.Data["+ i +"].InstanceType.SupportIoOptimized");
				instanceType.Cores = context.IntegerValue("DescribeRecommendInstanceType.Data["+ i +"].InstanceType.Cores");
				instanceType.Memory = context.IntegerValue("DescribeRecommendInstanceType.Data["+ i +"].InstanceType.Memory");
				recommendInstanceType.InstanceType = instanceType;

				List<DescribeRecommendInstanceTypeResponse.DescribeRecommendInstanceType_RecommendInstanceType.DescribeRecommendInstanceType_Zone> recommendInstanceType_zones = new List<DescribeRecommendInstanceTypeResponse.DescribeRecommendInstanceType_RecommendInstanceType.DescribeRecommendInstanceType_Zone>();
				for (int j = 0; j < context.Length("DescribeRecommendInstanceType.Data["+ i +"].Zones.Length"); j++) {
					DescribeRecommendInstanceTypeResponse.DescribeRecommendInstanceType_RecommendInstanceType.DescribeRecommendInstanceType_Zone zone = new DescribeRecommendInstanceTypeResponse.DescribeRecommendInstanceType_RecommendInstanceType.DescribeRecommendInstanceType_Zone();
					zone.ZoneNo = context.StringValue("DescribeRecommendInstanceType.Data["+ i +"].Zones["+ j +"].ZoneNo");

					List<string> zone_networkTypes = new List<string>();
					for (int k = 0; k < context.Length("DescribeRecommendInstanceType.Data["+ i +"].Zones["+ j +"].NetworkTypes.Length"); k++) {
						zone_networkTypes.Add(context.StringValue("DescribeRecommendInstanceType.Data["+ i +"].Zones["+ j +"].NetworkTypes["+ k +"]"));
					}
					zone.NetworkTypes = zone_networkTypes;

					recommendInstanceType_zones.Add(zone);
				}
				recommendInstanceType.Zones = recommendInstanceType_zones;

				describeRecommendInstanceTypeResponse_data.Add(recommendInstanceType);
			}
			describeRecommendInstanceTypeResponse.Data = describeRecommendInstanceTypeResponse_data;
        
			return describeRecommendInstanceTypeResponse;
        }
    }
}
