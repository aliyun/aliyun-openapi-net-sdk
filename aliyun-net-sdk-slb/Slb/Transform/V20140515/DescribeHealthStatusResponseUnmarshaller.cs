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
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeHealthStatusResponseUnmarshaller
    {
        public static DescribeHealthStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHealthStatusResponse describeHealthStatusResponse = new DescribeHealthStatusResponse();

			describeHealthStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeHealthStatusResponse.RequestId = _ctx.StringValue("DescribeHealthStatus.RequestId");

			List<DescribeHealthStatusResponse.DescribeHealthStatus_BackendServer> describeHealthStatusResponse_backendServers = new List<DescribeHealthStatusResponse.DescribeHealthStatus_BackendServer>();
			for (int i = 0; i < _ctx.Length("DescribeHealthStatus.BackendServers.Length"); i++) {
				DescribeHealthStatusResponse.DescribeHealthStatus_BackendServer backendServer = new DescribeHealthStatusResponse.DescribeHealthStatus_BackendServer();
				backendServer.ListenerPort = _ctx.IntegerValue("DescribeHealthStatus.BackendServers["+ i +"].ListenerPort");
				backendServer.ServerId = _ctx.StringValue("DescribeHealthStatus.BackendServers["+ i +"].ServerId");
				backendServer.Port = _ctx.IntegerValue("DescribeHealthStatus.BackendServers["+ i +"].Port");
				backendServer.ServerHealthStatus = _ctx.StringValue("DescribeHealthStatus.BackendServers["+ i +"].ServerHealthStatus");
				backendServer.ServerIp = _ctx.StringValue("DescribeHealthStatus.BackendServers["+ i +"].ServerIp");
				backendServer.EniHost = _ctx.StringValue("DescribeHealthStatus.BackendServers["+ i +"].EniHost");
				backendServer.Protocol = _ctx.StringValue("DescribeHealthStatus.BackendServers["+ i +"].Protocol");
				backendServer.Type = _ctx.StringValue("DescribeHealthStatus.BackendServers["+ i +"].Type");

				describeHealthStatusResponse_backendServers.Add(backendServer);
			}
			describeHealthStatusResponse.BackendServers = describeHealthStatusResponse_backendServers;
        
			return describeHealthStatusResponse;
        }
    }
}
