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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Slb.Model.V20140515;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class ModifyVServerGroupBackendServersResponseUnmarshaller
    {
        public static ModifyVServerGroupBackendServersResponse Unmarshall(UnmarshallerContext context)
        {
            ModifyVServerGroupBackendServersResponse modifyVServerGroupBackendServersResponse = new ModifyVServerGroupBackendServersResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("ModifyVServerGroupBackendServers.RequestId"),
                VServerGroupId = context.StringValue("ModifyVServerGroupBackendServers.VServerGroupId")
            };
            List<ModifyVServerGroupBackendServersResponse.BackendServer> backendServers = new List<ModifyVServerGroupBackendServersResponse.BackendServer>();
			for (int i = 0; i < context.Length("ModifyVServerGroupBackendServers.BackendServers.Length"); i++) {
                ModifyVServerGroupBackendServersResponse.BackendServer backendServer = new ModifyVServerGroupBackendServersResponse.BackendServer()
                {
                    ServerId = context.StringValue($"ModifyVServerGroupBackendServers.BackendServers[{i}].ServerId"),
                    Port = context.IntegerValue($"ModifyVServerGroupBackendServers.BackendServers[{i}].Port"),
                    Weight = context.IntegerValue($"ModifyVServerGroupBackendServers.BackendServers[{i}].Weight")
                };
                backendServers.Add(backendServer);
			}
			modifyVServerGroupBackendServersResponse.BackendServers = backendServers;
        
			return modifyVServerGroupBackendServersResponse;
        }
    }
}