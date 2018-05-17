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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.pvtz.Model.V20180101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.pvtz.Transform.V20180101
{
    public class DescribeZoneVpcTreeResponseUnmarshaller
    {
        public static DescribeZoneVpcTreeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeZoneVpcTreeResponse describeZoneVpcTreeResponse = new DescribeZoneVpcTreeResponse();

			describeZoneVpcTreeResponse.HttpResponse = context.HttpResponse;
			describeZoneVpcTreeResponse.RequestId = context.StringValue("DescribeZoneVpcTree.RequestId");

			List<DescribeZoneVpcTreeResponse.DescribeZoneVpcTree_Zone> describeZoneVpcTreeResponse_zones = new List<DescribeZoneVpcTreeResponse.DescribeZoneVpcTree_Zone>();
			for (int i = 0; i < context.Length("DescribeZoneVpcTree.Zones.Length"); i++) {
				DescribeZoneVpcTreeResponse.DescribeZoneVpcTree_Zone zone = new DescribeZoneVpcTreeResponse.DescribeZoneVpcTree_Zone();
				zone.ZoneId = context.StringValue("DescribeZoneVpcTree.Zones["+ i +"].ZoneId");
				zone.ZoneName = context.StringValue("DescribeZoneVpcTree.Zones["+ i +"].ZoneName");
				zone.Remark = context.StringValue("DescribeZoneVpcTree.Zones["+ i +"].Remark");
				zone.RecordCount = context.IntegerValue("DescribeZoneVpcTree.Zones["+ i +"].RecordCount");
				zone.CreateTime = context.StringValue("DescribeZoneVpcTree.Zones["+ i +"].CreateTime");
				zone.CreateTimestamp = context.LongValue("DescribeZoneVpcTree.Zones["+ i +"].CreateTimestamp");
				zone.UpdateTime = context.StringValue("DescribeZoneVpcTree.Zones["+ i +"].UpdateTime");
				zone.UpdateTimestamp = context.LongValue("DescribeZoneVpcTree.Zones["+ i +"].UpdateTimestamp");
				zone.IsPtr = context.BooleanValue("DescribeZoneVpcTree.Zones["+ i +"].IsPtr");

				List<DescribeZoneVpcTreeResponse.DescribeZoneVpcTree_Zone.DescribeZoneVpcTree_Vpc> zone_vpcs = new List<DescribeZoneVpcTreeResponse.DescribeZoneVpcTree_Zone.DescribeZoneVpcTree_Vpc>();
				for (int j = 0; j < context.Length("DescribeZoneVpcTree.Zones["+ i +"].Vpcs.Length"); j++) {
					DescribeZoneVpcTreeResponse.DescribeZoneVpcTree_Zone.DescribeZoneVpcTree_Vpc vpc = new DescribeZoneVpcTreeResponse.DescribeZoneVpcTree_Zone.DescribeZoneVpcTree_Vpc();
					vpc.RegionId = context.StringValue("DescribeZoneVpcTree.Zones["+ i +"].Vpcs["+ j +"].RegionId");
					vpc.RegionName = context.StringValue("DescribeZoneVpcTree.Zones["+ i +"].Vpcs["+ j +"].RegionName");
					vpc.VpcId = context.StringValue("DescribeZoneVpcTree.Zones["+ i +"].Vpcs["+ j +"].VpcId");
					vpc.VpcName = context.StringValue("DescribeZoneVpcTree.Zones["+ i +"].Vpcs["+ j +"].VpcName");

					zone_vpcs.Add(vpc);
				}
				zone.Vpcs = zone_vpcs;

				describeZoneVpcTreeResponse_zones.Add(zone);
			}
			describeZoneVpcTreeResponse.Zones = describeZoneVpcTreeResponse_zones;
        
			return describeZoneVpcTreeResponse;
        }
    }
}