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
        public static DescribeRoleZoneInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRoleZoneInfoResponse describeRoleZoneInfoResponse = new DescribeRoleZoneInfoResponse();

			describeRoleZoneInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeRoleZoneInfoResponse.RequestId = _ctx.StringValue("DescribeRoleZoneInfo.RequestId");
			describeRoleZoneInfoResponse.PageNumber = _ctx.IntegerValue("DescribeRoleZoneInfo.PageNumber");
			describeRoleZoneInfoResponse.PageSize = _ctx.IntegerValue("DescribeRoleZoneInfo.PageSize");
			describeRoleZoneInfoResponse.TotalCount = _ctx.IntegerValue("DescribeRoleZoneInfo.TotalCount");

			List<DescribeRoleZoneInfoResponse.DescribeRoleZoneInfo_NodeInfo> describeRoleZoneInfoResponse_node = new List<DescribeRoleZoneInfoResponse.DescribeRoleZoneInfo_NodeInfo>();
			for (int i = 0; i < _ctx.Length("DescribeRoleZoneInfo.Node.Length"); i++) {
				DescribeRoleZoneInfoResponse.DescribeRoleZoneInfo_NodeInfo nodeInfo = new DescribeRoleZoneInfoResponse.DescribeRoleZoneInfo_NodeInfo();
				nodeInfo.NodeId = _ctx.StringValue("DescribeRoleZoneInfo.Node["+ i +"].NodeId");
				nodeInfo.NodeType = _ctx.StringValue("DescribeRoleZoneInfo.Node["+ i +"].NodeType");
				nodeInfo.Role = _ctx.StringValue("DescribeRoleZoneInfo.Node["+ i +"].Role");
				nodeInfo.ZoneId = _ctx.StringValue("DescribeRoleZoneInfo.Node["+ i +"].ZoneId");
				nodeInfo.CPUUsage = _ctx.StringValue("DescribeRoleZoneInfo.Node["+ i +"].CPUUsage");
				nodeInfo.Connection = _ctx.FloatValue("DescribeRoleZoneInfo.Node["+ i +"].Connection");
				nodeInfo.AvgRt = _ctx.FloatValue("DescribeRoleZoneInfo.Node["+ i +"].AvgRt");
				nodeInfo.IntranetIn = _ctx.FloatValue("DescribeRoleZoneInfo.Node["+ i +"].IntranetIn");
				nodeInfo.IntranetOut = _ctx.FloatValue("DescribeRoleZoneInfo.Node["+ i +"].IntranetOut");
				nodeInfo.CustinsId = _ctx.StringValue("DescribeRoleZoneInfo.Node["+ i +"].CustinsId");
				nodeInfo.InsType = _ctx.IntegerValue("DescribeRoleZoneInfo.Node["+ i +"].InsType");
				nodeInfo.InsName = _ctx.StringValue("DescribeRoleZoneInfo.Node["+ i +"].InsName");
				nodeInfo.IsLatestVersion = _ctx.IntegerValue("DescribeRoleZoneInfo.Node["+ i +"].IsLatestVersion");
				nodeInfo.CurrentMinorVersion = _ctx.StringValue("DescribeRoleZoneInfo.Node["+ i +"].CurrentMinorVersion");
				nodeInfo.CurrentBandWidth = _ctx.LongValue("DescribeRoleZoneInfo.Node["+ i +"].CurrentBandWidth");
				nodeInfo.DefaultBandWidth = _ctx.LongValue("DescribeRoleZoneInfo.Node["+ i +"].DefaultBandWidth");
				nodeInfo.IsOpenBandWidthService = _ctx.BooleanValue("DescribeRoleZoneInfo.Node["+ i +"].IsOpenBandWidthService");

				describeRoleZoneInfoResponse_node.Add(nodeInfo);
			}
			describeRoleZoneInfoResponse.Node = describeRoleZoneInfoResponse_node;
        
			return describeRoleZoneInfoResponse;
        }
    }
}
