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
    public class RemoveBackendServersResponseUnmarshaller
    {
        public static RemoveBackendServersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RemoveBackendServersResponse removeBackendServersResponse = new RemoveBackendServersResponse();

			removeBackendServersResponse.HttpResponse = _ctx.HttpResponse;
			removeBackendServersResponse.RequestId = _ctx.StringValue("RemoveBackendServers.RequestId");
			removeBackendServersResponse.LoadBalancerId = _ctx.StringValue("RemoveBackendServers.LoadBalancerId");

			List<RemoveBackendServersResponse.RemoveBackendServers_BackendServer> removeBackendServersResponse_backendServers = new List<RemoveBackendServersResponse.RemoveBackendServers_BackendServer>();
			for (int i = 0; i < _ctx.Length("RemoveBackendServers.BackendServers.Length"); i++) {
				RemoveBackendServersResponse.RemoveBackendServers_BackendServer backendServer = new RemoveBackendServersResponse.RemoveBackendServers_BackendServer();
				backendServer.ServerId = _ctx.StringValue("RemoveBackendServers.BackendServers["+ i +"].ServerId");
				backendServer.Weight = _ctx.IntegerValue("RemoveBackendServers.BackendServers["+ i +"].Weight");
				backendServer.ServerIp = _ctx.StringValue("RemoveBackendServers.BackendServers["+ i +"].ServerIp");
				backendServer.VpcId = _ctx.StringValue("RemoveBackendServers.BackendServers["+ i +"].VpcId");
				backendServer.Type = _ctx.StringValue("RemoveBackendServers.BackendServers["+ i +"].Type");
				backendServer.Description = _ctx.StringValue("RemoveBackendServers.BackendServers["+ i +"].Description");

				removeBackendServersResponse_backendServers.Add(backendServer);
			}
			removeBackendServersResponse.BackendServers = removeBackendServersResponse_backendServers;
        
			return removeBackendServersResponse;
        }
    }
}
