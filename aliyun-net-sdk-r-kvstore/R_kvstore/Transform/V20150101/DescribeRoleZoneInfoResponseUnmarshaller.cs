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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeRoleZoneInfoResponseUnmarshaller
    {
        public static DescribeRoleZoneInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRoleZoneInfoResponse describeRoleZoneInfoResponse = new DescribeRoleZoneInfoResponse();

			describeRoleZoneInfoResponse.HttpResponse = context.HttpResponse;
			describeRoleZoneInfoResponse.RequestId = context.StringValue("DescribeRoleZoneInfo.RequestId");
			describeRoleZoneInfoResponse.PageNumber = context.IntegerValue("DescribeRoleZoneInfo.PageNumber");
			describeRoleZoneInfoResponse.PageSize = context.IntegerValue("DescribeRoleZoneInfo.PageSize");
			describeRoleZoneInfoResponse.TotalCount = context.IntegerValue("DescribeRoleZoneInfo.TotalCount");

			List<DescribeRoleZoneInfoResponse.DescribeRoleZoneInfo_NodeInfo> describeRoleZoneInfoResponse_node = new List<DescribeRoleZoneInfoResponse.DescribeRoleZoneInfo_NodeInfo>();
			for (int i = 0; i < context.Length("DescribeRoleZoneInfo.Node.Length"); i++) {
				DescribeRoleZoneInfoResponse.DescribeRoleZoneInfo_NodeInfo nodeInfo = new DescribeRoleZoneInfoResponse.DescribeRoleZoneInfo_NodeInfo();
				nodeInfo.NodeId = context.StringValue("DescribeRoleZoneInfo.Node["+ i +"].NodeId");
				nodeInfo.NodeType = context.StringValue("DescribeRoleZoneInfo.Node["+ i +"].NodeType");
				nodeInfo.Role = context.StringValue("DescribeRoleZoneInfo.Node["+ i +"].Role");
				nodeInfo.ZoneId = context.StringValue("DescribeRoleZoneInfo.Node["+ i +"].ZoneId");
				nodeInfo.CPUUsage = context.StringValue("DescribeRoleZoneInfo.Node["+ i +"].CPUUsage");
				nodeInfo.Connection = context.FloatValue("DescribeRoleZoneInfo.Node["+ i +"].Connection");
				nodeInfo.AvgRt = context.FloatValue("DescribeRoleZoneInfo.Node["+ i +"].AvgRt");
				nodeInfo.IntranetIn = context.FloatValue("DescribeRoleZoneInfo.Node["+ i +"].IntranetIn");
				nodeInfo.IntranetOut = context.FloatValue("DescribeRoleZoneInfo.Node["+ i +"].IntranetOut");
				nodeInfo.CustinsId = context.StringValue("DescribeRoleZoneInfo.Node["+ i +"].CustinsId");
				nodeInfo.InsType = context.IntegerValue("DescribeRoleZoneInfo.Node["+ i +"].InsType");
				nodeInfo.InsName = context.StringValue("DescribeRoleZoneInfo.Node["+ i +"].InsName");
				nodeInfo.IsLatestVersion = context.IntegerValue("DescribeRoleZoneInfo.Node["+ i +"].IsLatestVersion");
				nodeInfo.CurrentMinorVersion = context.StringValue("DescribeRoleZoneInfo.Node["+ i +"].CurrentMinorVersion");

				describeRoleZoneInfoResponse_node.Add(nodeInfo);
			}
			describeRoleZoneInfoResponse.Node = describeRoleZoneInfoResponse_node;
        
			return describeRoleZoneInfoResponse;
        }
    }
}
