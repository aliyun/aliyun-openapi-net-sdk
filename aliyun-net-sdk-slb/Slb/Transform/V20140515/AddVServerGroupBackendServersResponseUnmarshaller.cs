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
    public class AddVServerGroupBackendServersResponseUnmarshaller
    {
        public static AddVServerGroupBackendServersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddVServerGroupBackendServersResponse addVServerGroupBackendServersResponse = new AddVServerGroupBackendServersResponse();

			addVServerGroupBackendServersResponse.HttpResponse = _ctx.HttpResponse;
			addVServerGroupBackendServersResponse.RequestId = _ctx.StringValue("AddVServerGroupBackendServers.RequestId");
			addVServerGroupBackendServersResponse.VServerGroupId = _ctx.StringValue("AddVServerGroupBackendServers.VServerGroupId");

			List<AddVServerGroupBackendServersResponse.AddVServerGroupBackendServers_BackendServer> addVServerGroupBackendServersResponse_backendServers = new List<AddVServerGroupBackendServersResponse.AddVServerGroupBackendServers_BackendServer>();
			for (int i = 0; i < _ctx.Length("AddVServerGroupBackendServers.BackendServers.Length"); i++) {
				AddVServerGroupBackendServersResponse.AddVServerGroupBackendServers_BackendServer backendServer = new AddVServerGroupBackendServersResponse.AddVServerGroupBackendServers_BackendServer();
				backendServer.ServerId = _ctx.StringValue("AddVServerGroupBackendServers.BackendServers["+ i +"].ServerId");
				backendServer.Port = _ctx.IntegerValue("AddVServerGroupBackendServers.BackendServers["+ i +"].Port");
				backendServer.Weight = _ctx.IntegerValue("AddVServerGroupBackendServers.BackendServers["+ i +"].Weight");
				backendServer.Type = _ctx.StringValue("AddVServerGroupBackendServers.BackendServers["+ i +"].Type");
				backendServer.ServerIp = _ctx.StringValue("AddVServerGroupBackendServers.BackendServers["+ i +"].ServerIp");
				backendServer.VpcId = _ctx.StringValue("AddVServerGroupBackendServers.BackendServers["+ i +"].VpcId");
				backendServer.VbrId = _ctx.StringValue("AddVServerGroupBackendServers.BackendServers["+ i +"].VbrId");
				backendServer.ServerRegionId = _ctx.StringValue("AddVServerGroupBackendServers.BackendServers["+ i +"].ServerRegionId");
				backendServer.Description = _ctx.StringValue("AddVServerGroupBackendServers.BackendServers["+ i +"].Description");

				addVServerGroupBackendServersResponse_backendServers.Add(backendServer);
			}
			addVServerGroupBackendServersResponse.BackendServers = addVServerGroupBackendServersResponse_backendServers;
        
			return addVServerGroupBackendServersResponse;
        }
    }
}
