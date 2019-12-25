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
    public class ModifyVServerGroupBackendServersResponseUnmarshaller
    {
        public static ModifyVServerGroupBackendServersResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyVServerGroupBackendServersResponse modifyVServerGroupBackendServersResponse = new ModifyVServerGroupBackendServersResponse();

			modifyVServerGroupBackendServersResponse.HttpResponse = context.HttpResponse;
			modifyVServerGroupBackendServersResponse.RequestId = context.StringValue("ModifyVServerGroupBackendServers.RequestId");
			modifyVServerGroupBackendServersResponse.VServerGroupId = context.StringValue("ModifyVServerGroupBackendServers.VServerGroupId");

			List<ModifyVServerGroupBackendServersResponse.ModifyVServerGroupBackendServers_BackendServer> modifyVServerGroupBackendServersResponse_backendServers = new List<ModifyVServerGroupBackendServersResponse.ModifyVServerGroupBackendServers_BackendServer>();
			for (int i = 0; i < context.Length("ModifyVServerGroupBackendServers.BackendServers.Length"); i++) {
				ModifyVServerGroupBackendServersResponse.ModifyVServerGroupBackendServers_BackendServer backendServer = new ModifyVServerGroupBackendServersResponse.ModifyVServerGroupBackendServers_BackendServer();
				backendServer.ServerId = context.StringValue("ModifyVServerGroupBackendServers.BackendServers["+ i +"].ServerId");
				backendServer.Port = context.IntegerValue("ModifyVServerGroupBackendServers.BackendServers["+ i +"].Port");
				backendServer.Weight = context.IntegerValue("ModifyVServerGroupBackendServers.BackendServers["+ i +"].Weight");
				backendServer.Type = context.StringValue("ModifyVServerGroupBackendServers.BackendServers["+ i +"].Type");
				backendServer.ServerIp = context.StringValue("ModifyVServerGroupBackendServers.BackendServers["+ i +"].ServerIp");
				backendServer.VpcId = context.StringValue("ModifyVServerGroupBackendServers.BackendServers["+ i +"].VpcId");
				backendServer.VbrId = context.StringValue("ModifyVServerGroupBackendServers.BackendServers["+ i +"].VbrId");
				backendServer.ServerRegionId = context.StringValue("ModifyVServerGroupBackendServers.BackendServers["+ i +"].ServerRegionId");
				backendServer.Description = context.StringValue("ModifyVServerGroupBackendServers.BackendServers["+ i +"].Description");

				modifyVServerGroupBackendServersResponse_backendServers.Add(backendServer);
			}
			modifyVServerGroupBackendServersResponse.BackendServers = modifyVServerGroupBackendServersResponse_backendServers;
        
			return modifyVServerGroupBackendServersResponse;
        }
    }
}
