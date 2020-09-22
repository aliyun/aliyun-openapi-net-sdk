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
    public class DescribeGroupResponseUnmarshaller
    {
        public static DescribeGroupResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGroupResponse describeGroupResponse = new DescribeGroupResponse();

			describeGroupResponse.HttpResponse = context.HttpResponse;
			describeGroupResponse.RequestId = context.StringValue("DescribeGroup.RequestId");
			describeGroupResponse.Id = context.StringValue("DescribeGroup.Id");
			describeGroupResponse.AliasId = context.StringValue("DescribeGroup.AliasId");
			describeGroupResponse.Name = context.StringValue("DescribeGroup.Name");
			describeGroupResponse.Description = context.StringValue("DescribeGroup.Description");
			describeGroupResponse.App = context.StringValue("DescribeGroup.App");
			describeGroupResponse.Region = context.StringValue("DescribeGroup.Region");
			describeGroupResponse.InProtocol = context.StringValue("DescribeGroup.InProtocol");
			describeGroupResponse.OutProtocol = context.StringValue("DescribeGroup.OutProtocol");
			describeGroupResponse.Enabled = context.BooleanValue("DescribeGroup.Enabled");
			describeGroupResponse.Status = context.StringValue("DescribeGroup.Status");
			describeGroupResponse.CreatedTime = context.StringValue("DescribeGroup.CreatedTime");
			describeGroupResponse.PushDomain = context.StringValue("DescribeGroup.PushDomain");
			describeGroupResponse.PlayDomain = context.StringValue("DescribeGroup.PlayDomain");
			describeGroupResponse.LazyPull = context.BooleanValue("DescribeGroup.LazyPull");
			describeGroupResponse.Callback = context.StringValue("DescribeGroup.Callback");
			describeGroupResponse.CaptureInterval = context.IntegerValue("DescribeGroup.CaptureInterval");
			describeGroupResponse.CaptureImage = context.IntegerValue("DescribeGroup.CaptureImage");
			describeGroupResponse.CaptureVideo = context.IntegerValue("DescribeGroup.CaptureVideo");
			describeGroupResponse.CaptureOssBucket = context.StringValue("DescribeGroup.CaptureOssBucket");
			describeGroupResponse.CaptureOssPath = context.StringValue("DescribeGroup.CaptureOssPath");
			describeGroupResponse.GbId = context.StringValue("DescribeGroup.GbId");
			describeGroupResponse.GbIp = context.StringValue("DescribeGroup.GbIp");
			describeGroupResponse.GbPort = context.LongValue("DescribeGroup.GbPort");

			List<string> describeGroupResponse_gbUdpPorts = new List<string>();
			for (int i = 0; i < context.Length("DescribeGroup.GbUdpPorts.Length"); i++) {
				describeGroupResponse_gbUdpPorts.Add(context.StringValue("DescribeGroup.GbUdpPorts["+ i +"]"));
			}
			describeGroupResponse.GbUdpPorts = describeGroupResponse_gbUdpPorts;

			List<string> describeGroupResponse_gbTcpPorts = new List<string>();
			for (int i = 0; i < context.Length("DescribeGroup.GbTcpPorts.Length"); i++) {
				describeGroupResponse_gbTcpPorts.Add(context.StringValue("DescribeGroup.GbTcpPorts["+ i +"]"));
			}
			describeGroupResponse.GbTcpPorts = describeGroupResponse_gbTcpPorts;

			DescribeGroupResponse.DescribeGroup_Stats stats = new DescribeGroupResponse.DescribeGroup_Stats();
			stats.DeviceNum = context.LongValue("DescribeGroup.Stats.DeviceNum");
			stats.IedNum = context.LongValue("DescribeGroup.Stats.IedNum");
			stats.IpcNum = context.LongValue("DescribeGroup.Stats.IpcNum");
			stats.PlatformNum = context.LongValue("DescribeGroup.Stats.PlatformNum");
			describeGroupResponse.Stats = stats;
        
			return describeGroupResponse;
        }
    }
}
