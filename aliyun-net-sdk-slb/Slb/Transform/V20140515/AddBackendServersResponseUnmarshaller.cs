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
    public class AddBackendServersResponseUnmarshaller
    {
        public static AddBackendServersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddBackendServersResponse addBackendServersResponse = new AddBackendServersResponse();

			addBackendServersResponse.HttpResponse = _ctx.HttpResponse;
			addBackendServersResponse.RequestId = _ctx.StringValue("AddBackendServers.RequestId");
			addBackendServersResponse.LoadBalancerId = _ctx.StringValue("AddBackendServers.LoadBalancerId");

			List<AddBackendServersResponse.AddBackendServers_BackendServer> addBackendServersResponse_backendServers = new List<AddBackendServersResponse.AddBackendServers_BackendServer>();
			for (int i = 0; i < _ctx.Length("AddBackendServers.BackendServers.Length"); i++) {
				AddBackendServersResponse.AddBackendServers_BackendServer backendServer = new AddBackendServersResponse.AddBackendServers_BackendServer();
				backendServer.ServerId = _ctx.StringValue("AddBackendServers.BackendServers["+ i +"].ServerId");
				backendServer.Weight = _ctx.StringValue("AddBackendServers.BackendServers["+ i +"].Weight");
				backendServer.ServerIp = _ctx.StringValue("AddBackendServers.BackendServers["+ i +"].ServerIp");
				backendServer.VpcId = _ctx.StringValue("AddBackendServers.BackendServers["+ i +"].VpcId");
				backendServer.Type = _ctx.StringValue("AddBackendServers.BackendServers["+ i +"].Type");
				backendServer.Description = _ctx.StringValue("AddBackendServers.BackendServers["+ i +"].Description");

				addBackendServersResponse_backendServers.Add(backendServer);
			}
			addBackendServersResponse.BackendServers = addBackendServersResponse_backendServers;
        
			return addBackendServersResponse;
        }
    }
}
