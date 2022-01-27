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
        public static DescribeGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGroupResponse describeGroupResponse = new DescribeGroupResponse();

			describeGroupResponse.HttpResponse = _ctx.HttpResponse;
			describeGroupResponse.RequestId = _ctx.StringValue("DescribeGroup.RequestId");
			describeGroupResponse.Id = _ctx.StringValue("DescribeGroup.Id");
			describeGroupResponse.AliasId = _ctx.StringValue("DescribeGroup.AliasId");
			describeGroupResponse.Name = _ctx.StringValue("DescribeGroup.Name");
			describeGroupResponse.Description = _ctx.StringValue("DescribeGroup.Description");
			describeGroupResponse.App = _ctx.StringValue("DescribeGroup.App");
			describeGroupResponse.Region = _ctx.StringValue("DescribeGroup.Region");
			describeGroupResponse.InProtocol = _ctx.StringValue("DescribeGroup.InProtocol");
			describeGroupResponse.OutProtocol = _ctx.StringValue("DescribeGroup.OutProtocol");
			describeGroupResponse.Enabled = _ctx.BooleanValue("DescribeGroup.Enabled");
			describeGroupResponse.Status = _ctx.StringValue("DescribeGroup.Status");
			describeGroupResponse.CreatedTime = _ctx.StringValue("DescribeGroup.CreatedTime");
			describeGroupResponse.PushDomain = _ctx.StringValue("DescribeGroup.PushDomain");
			describeGroupResponse.PlayDomain = _ctx.StringValue("DescribeGroup.PlayDomain");
			describeGroupResponse.LazyPull = _ctx.BooleanValue("DescribeGroup.LazyPull");
			describeGroupResponse.Callback = _ctx.StringValue("DescribeGroup.Callback");
			describeGroupResponse.CaptureInterval = _ctx.IntegerValue("DescribeGroup.CaptureInterval");
			describeGroupResponse.CaptureImage = _ctx.IntegerValue("DescribeGroup.CaptureImage");
			describeGroupResponse.CaptureVideo = _ctx.IntegerValue("DescribeGroup.CaptureVideo");
			describeGroupResponse.CaptureOssBucket = _ctx.StringValue("DescribeGroup.CaptureOssBucket");
			describeGroupResponse.CaptureOssPath = _ctx.StringValue("DescribeGroup.CaptureOssPath");
			describeGroupResponse.GbId = _ctx.StringValue("DescribeGroup.GbId");
			describeGroupResponse.GbIp = _ctx.StringValue("DescribeGroup.GbIp");
			describeGroupResponse.GbPort = _ctx.LongValue("DescribeGroup.GbPort");

			List<string> describeGroupResponse_gbUdpPorts = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeGroup.GbUdpPorts.Length"); i++) {
				describeGroupResponse_gbUdpPorts.Add(_ctx.StringValue("DescribeGroup.GbUdpPorts["+ i +"]"));
			}
			describeGroupResponse.GbUdpPorts = describeGroupResponse_gbUdpPorts;

			List<string> describeGroupResponse_gbTcpPorts = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeGroup.GbTcpPorts.Length"); i++) {
				describeGroupResponse_gbTcpPorts.Add(_ctx.StringValue("DescribeGroup.GbTcpPorts["+ i +"]"));
			}
			describeGroupResponse.GbTcpPorts = describeGroupResponse_gbTcpPorts;

			DescribeGroupResponse.DescribeGroup_Stats stats = new DescribeGroupResponse.DescribeGroup_Stats();
			stats.DeviceNum = _ctx.LongValue("DescribeGroup.Stats.DeviceNum");
			stats.IedNum = _ctx.LongValue("DescribeGroup.Stats.IedNum");
			stats.IpcNum = _ctx.LongValue("DescribeGroup.Stats.IpcNum");
			stats.PlatformNum = _ctx.LongValue("DescribeGroup.Stats.PlatformNum");
			describeGroupResponse.Stats = stats;
        
			return describeGroupResponse;
        }
    }
}
