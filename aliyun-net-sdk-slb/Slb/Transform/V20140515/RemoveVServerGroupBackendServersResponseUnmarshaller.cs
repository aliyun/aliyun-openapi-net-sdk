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
    public class RemoveVServerGroupBackendServersResponseUnmarshaller
    {
        public static RemoveVServerGroupBackendServersResponse Unmarshall(UnmarshallerContext context)
        {
			RemoveVServerGroupBackendServersResponse removeVServerGroupBackendServersResponse = new RemoveVServerGroupBackendServersResponse();

			removeVServerGroupBackendServersResponse.HttpResponse = context.HttpResponse;
			removeVServerGroupBackendServersResponse.RequestId = context.StringValue("RemoveVServerGroupBackendServers.RequestId");
			removeVServerGroupBackendServersResponse.VServerGroupId = context.StringValue("RemoveVServerGroupBackendServers.VServerGroupId");

			List<RemoveVServerGroupBackendServersResponse.RemoveVServerGroupBackendServers_BackendServer> removeVServerGroupBackendServersResponse_backendServers = new List<RemoveVServerGroupBackendServersResponse.RemoveVServerGroupBackendServers_BackendServer>();
			for (int i = 0; i < context.Length("RemoveVServerGroupBackendServers.BackendServers.Length"); i++) {
				RemoveVServerGroupBackendServersResponse.RemoveVServerGroupBackendServers_BackendServer backendServer = new RemoveVServerGroupBackendServersResponse.RemoveVServerGroupBackendServers_BackendServer();
				backendServer.ServerId = context.StringValue("RemoveVServerGroupBackendServers.BackendServers["+ i +"].ServerId");
				backendServer.Port = context.IntegerValue("RemoveVServerGroupBackendServers.BackendServers["+ i +"].Port");
				backendServer.Weight = context.IntegerValue("RemoveVServerGroupBackendServers.BackendServers["+ i +"].Weight");
				backendServer.Type = context.StringValue("RemoveVServerGroupBackendServers.BackendServers["+ i +"].Type");
				backendServer.ServerIp = context.StringValue("RemoveVServerGroupBackendServers.BackendServers["+ i +"].ServerIp");
				backendServer.VpcId = context.StringValue("RemoveVServerGroupBackendServers.BackendServers["+ i +"].VpcId");
				backendServer.Description = context.StringValue("RemoveVServerGroupBackendServers.BackendServers["+ i +"].Description");

				removeVServerGroupBackendServersResponse_backendServers.Add(backendServer);
			}
			removeVServerGroupBackendServersResponse.BackendServers = removeVServerGroupBackendServersResponse_backendServers;
        
			return removeVServerGroupBackendServersResponse;
        }
    }
}
