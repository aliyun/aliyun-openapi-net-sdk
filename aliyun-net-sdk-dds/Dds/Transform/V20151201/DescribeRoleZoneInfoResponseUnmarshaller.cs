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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeRoleZoneInfoResponseUnmarshaller
    {
        public static DescribeRoleZoneInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRoleZoneInfoResponse describeRoleZoneInfoResponse = new DescribeRoleZoneInfoResponse();

			describeRoleZoneInfoResponse.HttpResponse = context.HttpResponse;
			describeRoleZoneInfoResponse.RequestId = context.StringValue("DescribeRoleZoneInfo.RequestId");

			List<DescribeRoleZoneInfoResponse.DescribeRoleZoneInfo_ZoneInfo> describeRoleZoneInfoResponse_zoneInfos = new List<DescribeRoleZoneInfoResponse.DescribeRoleZoneInfo_ZoneInfo>();
			for (int i = 0; i < context.Length("DescribeRoleZoneInfo.ZoneInfos.Length"); i++) {
				DescribeRoleZoneInfoResponse.DescribeRoleZoneInfo_ZoneInfo zoneInfo = new DescribeRoleZoneInfoResponse.DescribeRoleZoneInfo_ZoneInfo();
				zoneInfo.NodeType = context.StringValue("DescribeRoleZoneInfo.ZoneInfos["+ i +"].NodeType");
				zoneInfo.RoleType = context.StringValue("DescribeRoleZoneInfo.ZoneInfos["+ i +"].RoleType");
				zoneInfo.ZoneId = context.StringValue("DescribeRoleZoneInfo.ZoneInfos["+ i +"].ZoneId");
				zoneInfo.RoleId = context.StringValue("DescribeRoleZoneInfo.ZoneInfos["+ i +"].RoleId");
				zoneInfo.InsName = context.StringValue("DescribeRoleZoneInfo.ZoneInfos["+ i +"].InsName");

				describeRoleZoneInfoResponse_zoneInfos.Add(zoneInfo);
			}
			describeRoleZoneInfoResponse.ZoneInfos = describeRoleZoneInfoResponse_zoneInfos;
        
			return describeRoleZoneInfoResponse;
        }
    }
}
