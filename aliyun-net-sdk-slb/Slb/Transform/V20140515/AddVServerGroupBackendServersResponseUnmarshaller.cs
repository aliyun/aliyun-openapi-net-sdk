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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class AddVServerGroupBackendServersResponseUnmarshaller
    {
        public static AddVServerGroupBackendServersResponse Unmarshall(UnmarshallerContext context)
        {
            AddVServerGroupBackendServersResponse addVServerGroupBackendServersResponse = new AddVServerGroupBackendServersResponse();

            addVServerGroupBackendServersResponse.HttpResponse = context.HttpResponse;
            addVServerGroupBackendServersResponse.RequestId = context.StringValue("AddVServerGroupBackendServers.RequestId");
            addVServerGroupBackendServersResponse.VServerGroupId = context.StringValue("AddVServerGroupBackendServers.VServerGroupId");

            List<AddVServerGroupBackendServersResponse.AddVServerGroupBackendServers_BackendServer> addVServerGroupBackendServersResponse_backendServers = new List<AddVServerGroupBackendServersResponse.AddVServerGroupBackendServers_BackendServer>();
            for (int i = 0; i < context.Length("AddVServerGroupBackendServers.BackendServers.Length"); i++)
            {
                AddVServerGroupBackendServersResponse.AddVServerGroupBackendServers_BackendServer backendServer = new AddVServerGroupBackendServersResponse.AddVServerGroupBackendServers_BackendServer();
                backendServer.ServerId = context.StringValue("AddVServerGroupBackendServers.BackendServers[" + i + "].ServerId");
                backendServer.Port = context.IntegerValue("AddVServerGroupBackendServers.BackendServers[" + i + "].Port");
                backendServer.Weight = context.IntegerValue("AddVServerGroupBackendServers.BackendServers[" + i + "].Weight");
                backendServer.Type = context.StringValue("AddVServerGroupBackendServers.BackendServers[" + i + "].Type");
                backendServer.ServerIp = context.StringValue("AddVServerGroupBackendServers.BackendServers[" + i + "].ServerIp");
                backendServer.VpcId = context.StringValue("AddVServerGroupBackendServers.BackendServers[" + i + "].VpcId");

                addVServerGroupBackendServersResponse_backendServers.Add(backendServer);
            }
            addVServerGroupBackendServersResponse.BackendServers = addVServerGroupBackendServersResponse_backendServers;

            return addVServerGroupBackendServersResponse;
        }
    }
}