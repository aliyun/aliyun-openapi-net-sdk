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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeGroupsResponseUnmarshaller
    {
        public static DescribeGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGroupsResponse describeGroupsResponse = new DescribeGroupsResponse();

			describeGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeGroupsResponse.RequestId = _ctx.StringValue("DescribeGroups.RequestId");
			describeGroupsResponse.PageSize = _ctx.LongValue("DescribeGroups.PageSize");
			describeGroupsResponse.PageNum = _ctx.LongValue("DescribeGroups.PageNum");
			describeGroupsResponse.PageCount = _ctx.LongValue("DescribeGroups.PageCount");
			describeGroupsResponse.TotalCount = _ctx.LongValue("DescribeGroups.TotalCount");

			List<DescribeGroupsResponse.DescribeGroups_Group> describeGroupsResponse_groups = new List<DescribeGroupsResponse.DescribeGroups_Group>();
			for (int i = 0; i < _ctx.Length("DescribeGroups.Groups.Length"); i++) {
				DescribeGroupsResponse.DescribeGroups_Group group = new DescribeGroupsResponse.DescribeGroups_Group();
				group.Id = _ctx.StringValue("DescribeGroups.Groups["+ i +"].Id");
				group.AliasId = _ctx.StringValue("DescribeGroups.Groups["+ i +"].AliasId");
				group.Name = _ctx.StringValue("DescribeGroups.Groups["+ i +"].Name");
				group.Description = _ctx.StringValue("DescribeGroups.Groups["+ i +"].Description");
				group.App = _ctx.StringValue("DescribeGroups.Groups["+ i +"].App");
				group.Region = _ctx.StringValue("DescribeGroups.Groups["+ i +"].Region");
				group.InProtocol = _ctx.StringValue("DescribeGroups.Groups["+ i +"].InProtocol");
				group.OutProtocol = _ctx.StringValue("DescribeGroups.Groups["+ i +"].OutProtocol");
				group.Enabled = _ctx.BooleanValue("DescribeGroups.Groups["+ i +"].Enabled");
				group.Status = _ctx.StringValue("DescribeGroups.Groups["+ i +"].Status");
				group.CreatedTime = _ctx.StringValue("DescribeGroups.Groups["+ i +"].CreatedTime");
				group.PushDomain = _ctx.StringValue("DescribeGroups.Groups["+ i +"].PushDomain");
				group.PlayDomain = _ctx.StringValue("DescribeGroups.Groups["+ i +"].PlayDomain");
				group.LazyPull = _ctx.BooleanValue("DescribeGroups.Groups["+ i +"].LazyPull");
				group.Callback = _ctx.StringValue("DescribeGroups.Groups["+ i +"].Callback");
				group.CaptureInterval = _ctx.IntegerValue("DescribeGroups.Groups["+ i +"].CaptureInterval");
				group.CaptureImage = _ctx.IntegerValue("DescribeGroups.Groups["+ i +"].CaptureImage");
				group.CaptureVideo = _ctx.IntegerValue("DescribeGroups.Groups["+ i +"].CaptureVideo");
				group.CaptureOssBucket = _ctx.StringValue("DescribeGroups.Groups["+ i +"].CaptureOssBucket");
				group.CaptureOssPath = _ctx.StringValue("DescribeGroups.Groups["+ i +"].CaptureOssPath");
				group.GbId = _ctx.StringValue("DescribeGroups.Groups["+ i +"].GbId");
				group.GbIp = _ctx.StringValue("DescribeGroups.Groups["+ i +"].GbIp");
				group.GbPort = _ctx.LongValue("DescribeGroups.Groups["+ i +"].GbPort");

				List<string> group_gbUdpPorts = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeGroups.Groups["+ i +"].GbUdpPorts.Length"); j++) {
					group_gbUdpPorts.Add(_ctx.StringValue("DescribeGroups.Groups["+ i +"].GbUdpPorts["+ j +"]"));
				}
				group.GbUdpPorts = group_gbUdpPorts;

				List<string> group_gbTcpPorts = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeGroups.Groups["+ i +"].GbTcpPorts.Length"); j++) {
					group_gbTcpPorts.Add(_ctx.StringValue("DescribeGroups.Groups["+ i +"].GbTcpPorts["+ j +"]"));
				}
				group.GbTcpPorts = group_gbTcpPorts;

				DescribeGroupsResponse.DescribeGroups_Group.DescribeGroups_Stats stats = new DescribeGroupsResponse.DescribeGroups_Group.DescribeGroups_Stats();
				stats.DeviceNum = _ctx.LongValue("DescribeGroups.Groups["+ i +"].Stats.DeviceNum");
				stats.IedNum = _ctx.LongValue("DescribeGroups.Groups["+ i +"].Stats.IedNum");
				stats.IpcNum = _ctx.LongValue("DescribeGroups.Groups["+ i +"].Stats.IpcNum");
				stats.PlatformNum = _ctx.LongValue("DescribeGroups.Groups["+ i +"].Stats.PlatformNum");
				group.Stats = stats;

				describeGroupsResponse_groups.Add(group);
			}
			describeGroupsResponse.Groups = describeGroupsResponse_groups;
        
			return describeGroupsResponse;
        }
    }
}
