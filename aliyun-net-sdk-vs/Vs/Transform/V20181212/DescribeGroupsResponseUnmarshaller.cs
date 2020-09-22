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
        public static DescribeGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGroupsResponse describeGroupsResponse = new DescribeGroupsResponse();

			describeGroupsResponse.HttpResponse = context.HttpResponse;
			describeGroupsResponse.RequestId = context.StringValue("DescribeGroups.RequestId");
			describeGroupsResponse.PageSize = context.LongValue("DescribeGroups.PageSize");
			describeGroupsResponse.PageNum = context.LongValue("DescribeGroups.PageNum");
			describeGroupsResponse.PageCount = context.LongValue("DescribeGroups.PageCount");
			describeGroupsResponse.TotalCount = context.LongValue("DescribeGroups.TotalCount");

			List<DescribeGroupsResponse.DescribeGroups_Group> describeGroupsResponse_groups = new List<DescribeGroupsResponse.DescribeGroups_Group>();
			for (int i = 0; i < context.Length("DescribeGroups.Groups.Length"); i++) {
				DescribeGroupsResponse.DescribeGroups_Group group = new DescribeGroupsResponse.DescribeGroups_Group();
				group.Id = context.StringValue("DescribeGroups.Groups["+ i +"].Id");
				group.AliasId = context.StringValue("DescribeGroups.Groups["+ i +"].AliasId");
				group.Name = context.StringValue("DescribeGroups.Groups["+ i +"].Name");
				group.Description = context.StringValue("DescribeGroups.Groups["+ i +"].Description");
				group.App = context.StringValue("DescribeGroups.Groups["+ i +"].App");
				group.Region = context.StringValue("DescribeGroups.Groups["+ i +"].Region");
				group.InProtocol = context.StringValue("DescribeGroups.Groups["+ i +"].InProtocol");
				group.OutProtocol = context.StringValue("DescribeGroups.Groups["+ i +"].OutProtocol");
				group.Enabled = context.BooleanValue("DescribeGroups.Groups["+ i +"].Enabled");
				group.Status = context.StringValue("DescribeGroups.Groups["+ i +"].Status");
				group.CreatedTime = context.StringValue("DescribeGroups.Groups["+ i +"].CreatedTime");
				group.PushDomain = context.StringValue("DescribeGroups.Groups["+ i +"].PushDomain");
				group.PlayDomain = context.StringValue("DescribeGroups.Groups["+ i +"].PlayDomain");
				group.LazyPull = context.BooleanValue("DescribeGroups.Groups["+ i +"].LazyPull");
				group.Callback = context.StringValue("DescribeGroups.Groups["+ i +"].Callback");
				group.CaptureInterval = context.IntegerValue("DescribeGroups.Groups["+ i +"].CaptureInterval");
				group.CaptureImage = context.IntegerValue("DescribeGroups.Groups["+ i +"].CaptureImage");
				group.CaptureVideo = context.IntegerValue("DescribeGroups.Groups["+ i +"].CaptureVideo");
				group.CaptureOssBucket = context.StringValue("DescribeGroups.Groups["+ i +"].CaptureOssBucket");
				group.CaptureOssPath = context.StringValue("DescribeGroups.Groups["+ i +"].CaptureOssPath");
				group.GbId = context.StringValue("DescribeGroups.Groups["+ i +"].GbId");
				group.GbIp = context.StringValue("DescribeGroups.Groups["+ i +"].GbIp");
				group.GbPort = context.LongValue("DescribeGroups.Groups["+ i +"].GbPort");

				List<string> group_gbUdpPorts = new List<string>();
				for (int j = 0; j < context.Length("DescribeGroups.Groups["+ i +"].GbUdpPorts.Length"); j++) {
					group_gbUdpPorts.Add(context.StringValue("DescribeGroups.Groups["+ i +"].GbUdpPorts["+ j +"]"));
				}
				group.GbUdpPorts = group_gbUdpPorts;

				List<string> group_gbTcpPorts = new List<string>();
				for (int j = 0; j < context.Length("DescribeGroups.Groups["+ i +"].GbTcpPorts.Length"); j++) {
					group_gbTcpPorts.Add(context.StringValue("DescribeGroups.Groups["+ i +"].GbTcpPorts["+ j +"]"));
				}
				group.GbTcpPorts = group_gbTcpPorts;

				DescribeGroupsResponse.DescribeGroups_Group.DescribeGroups_Stats stats = new DescribeGroupsResponse.DescribeGroups_Group.DescribeGroups_Stats();
				stats.DeviceNum = context.LongValue("DescribeGroups.Groups["+ i +"].Stats.DeviceNum");
				stats.IedNum = context.LongValue("DescribeGroups.Groups["+ i +"].Stats.IedNum");
				stats.IpcNum = context.LongValue("DescribeGroups.Groups["+ i +"].Stats.IpcNum");
				stats.PlatformNum = context.LongValue("DescribeGroups.Groups["+ i +"].Stats.PlatformNum");
				group.Stats = stats;

				describeGroupsResponse_groups.Add(group);
			}
			describeGroupsResponse.Groups = describeGroupsResponse_groups;
        
			return describeGroupsResponse;
        }
    }
}
