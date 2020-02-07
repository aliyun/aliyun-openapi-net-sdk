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
using Aliyun.Acs.pvtz.Model.V20180101;

namespace Aliyun.Acs.pvtz.Transform.V20180101
{
    public class DescribeZoneInfoResponseUnmarshaller
    {
        public static DescribeZoneInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeZoneInfoResponse describeZoneInfoResponse = new DescribeZoneInfoResponse();

			describeZoneInfoResponse.HttpResponse = context.HttpResponse;
			describeZoneInfoResponse.RequestId = context.StringValue("DescribeZoneInfo.RequestId");
			describeZoneInfoResponse.ZoneId = context.StringValue("DescribeZoneInfo.ZoneId");
			describeZoneInfoResponse.ZoneName = context.StringValue("DescribeZoneInfo.ZoneName");
			describeZoneInfoResponse.Remark = context.StringValue("DescribeZoneInfo.Remark");
			describeZoneInfoResponse.RecordCount = context.IntegerValue("DescribeZoneInfo.RecordCount");
			describeZoneInfoResponse.CreateTime = context.StringValue("DescribeZoneInfo.CreateTime");
			describeZoneInfoResponse.CreateTimestamp = context.LongValue("DescribeZoneInfo.CreateTimestamp");
			describeZoneInfoResponse.UpdateTime = context.StringValue("DescribeZoneInfo.UpdateTime");
			describeZoneInfoResponse.UpdateTimestamp = context.LongValue("DescribeZoneInfo.UpdateTimestamp");
			describeZoneInfoResponse.IsPtr = context.BooleanValue("DescribeZoneInfo.IsPtr");
			describeZoneInfoResponse.ProxyPattern = context.StringValue("DescribeZoneInfo.ProxyPattern");
			describeZoneInfoResponse.SlaveDns = context.BooleanValue("DescribeZoneInfo.SlaveDns");

			List<DescribeZoneInfoResponse.DescribeZoneInfo_Vpc> describeZoneInfoResponse_bindVpcs = new List<DescribeZoneInfoResponse.DescribeZoneInfo_Vpc>();
			for (int i = 0; i < context.Length("DescribeZoneInfo.BindVpcs.Length"); i++) {
				DescribeZoneInfoResponse.DescribeZoneInfo_Vpc vpc = new DescribeZoneInfoResponse.DescribeZoneInfo_Vpc();
				vpc.VpcId = context.StringValue("DescribeZoneInfo.BindVpcs["+ i +"].VpcId");
				vpc.VpcName = context.StringValue("DescribeZoneInfo.BindVpcs["+ i +"].VpcName");
				vpc.RegionName = context.StringValue("DescribeZoneInfo.BindVpcs["+ i +"].RegionName");
				vpc.RegionId = context.StringValue("DescribeZoneInfo.BindVpcs["+ i +"].RegionId");

				describeZoneInfoResponse_bindVpcs.Add(vpc);
			}
			describeZoneInfoResponse.BindVpcs = describeZoneInfoResponse_bindVpcs;
        
			return describeZoneInfoResponse;
        }
    }
}
