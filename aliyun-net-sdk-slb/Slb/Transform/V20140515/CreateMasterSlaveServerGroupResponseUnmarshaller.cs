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
    public class CreateMasterSlaveServerGroupResponseUnmarshaller
    {
        public static CreateMasterSlaveServerGroupResponse Unmarshall(UnmarshallerContext context)
        {
			CreateMasterSlaveServerGroupResponse createMasterSlaveServerGroupResponse = new CreateMasterSlaveServerGroupResponse();

			createMasterSlaveServerGroupResponse.HttpResponse = context.HttpResponse;
			createMasterSlaveServerGroupResponse.RequestId = context.StringValue("CreateMasterSlaveServerGroup.RequestId");
			createMasterSlaveServerGroupResponse.MasterSlaveServerGroupId = context.StringValue("CreateMasterSlaveServerGroup.MasterSlaveServerGroupId");

			List<CreateMasterSlaveServerGroupResponse.CreateMasterSlaveServerGroup_MasterSlaveBackendServer> createMasterSlaveServerGroupResponse_masterSlaveBackendServers = new List<CreateMasterSlaveServerGroupResponse.CreateMasterSlaveServerGroup_MasterSlaveBackendServer>();
			for (int i = 0; i < context.Length("CreateMasterSlaveServerGroup.MasterSlaveBackendServers.Length"); i++) {
				CreateMasterSlaveServerGroupResponse.CreateMasterSlaveServerGroup_MasterSlaveBackendServer masterSlaveBackendServer = new CreateMasterSlaveServerGroupResponse.CreateMasterSlaveServerGroup_MasterSlaveBackendServer();
				masterSlaveBackendServer.ServerId = context.StringValue("CreateMasterSlaveServerGroup.MasterSlaveBackendServers["+ i +"].ServerId");
				masterSlaveBackendServer.Port = context.IntegerValue("CreateMasterSlaveServerGroup.MasterSlaveBackendServers["+ i +"].Port");
				masterSlaveBackendServer.Weight = context.IntegerValue("CreateMasterSlaveServerGroup.MasterSlaveBackendServers["+ i +"].Weight");
				masterSlaveBackendServer.ServerType = context.StringValue("CreateMasterSlaveServerGroup.MasterSlaveBackendServers["+ i +"].ServerType");

				createMasterSlaveServerGroupResponse_masterSlaveBackendServers.Add(masterSlaveBackendServer);
			}
			createMasterSlaveServerGroupResponse.MasterSlaveBackendServers = createMasterSlaveServerGroupResponse_masterSlaveBackendServers;
        
			return createMasterSlaveServerGroupResponse;
        }
    }
}