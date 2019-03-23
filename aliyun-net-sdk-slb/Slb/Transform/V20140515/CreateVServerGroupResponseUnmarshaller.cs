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
    public class CreateVServerGroupResponseUnmarshaller
    {
        public static CreateVServerGroupResponse Unmarshall(UnmarshallerContext context)
        {
            CreateVServerGroupResponse createVServerGroupResponse = new CreateVServerGroupResponse();

            createVServerGroupResponse.HttpResponse = context.HttpResponse;
            createVServerGroupResponse.RequestId = context.StringValue("CreateVServerGroup.RequestId");
            createVServerGroupResponse.VServerGroupId = context.StringValue("CreateVServerGroup.VServerGroupId");

            List<CreateVServerGroupResponse.CreateVServerGroup_BackendServer> createVServerGroupResponse_backendServers = new List<CreateVServerGroupResponse.CreateVServerGroup_BackendServer>();
            for (int i = 0; i < context.Length("CreateVServerGroup.BackendServers.Length"); i++)
            {
                CreateVServerGroupResponse.CreateVServerGroup_BackendServer backendServer = new CreateVServerGroupResponse.CreateVServerGroup_BackendServer();
                backendServer.ServerId = context.StringValue("CreateVServerGroup.BackendServers[" + i + "].ServerId");
                backendServer.Port = context.IntegerValue("CreateVServerGroup.BackendServers[" + i + "].Port");
                backendServer.Weight = context.IntegerValue("CreateVServerGroup.BackendServers[" + i + "].Weight");
                backendServer.Type = context.StringValue("CreateVServerGroup.BackendServers[" + i + "].Type");
                backendServer.ServerIp = context.StringValue("CreateVServerGroup.BackendServers[" + i + "].ServerIp");
                backendServer.VpcId = context.StringValue("CreateVServerGroup.BackendServers[" + i + "].VpcId");

                createVServerGroupResponse_backendServers.Add(backendServer);
            }
            createVServerGroupResponse.BackendServers = createVServerGroupResponse_backendServers;

            return createVServerGroupResponse;
        }
    }
}