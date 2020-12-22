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
    public class CreateMasterSlaveServerGroupResponseUnmarshaller
    {
        public static CreateMasterSlaveServerGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateMasterSlaveServerGroupResponse createMasterSlaveServerGroupResponse = new CreateMasterSlaveServerGroupResponse();

			createMasterSlaveServerGroupResponse.HttpResponse = _ctx.HttpResponse;
			createMasterSlaveServerGroupResponse.RequestId = _ctx.StringValue("CreateMasterSlaveServerGroup.RequestId");
			createMasterSlaveServerGroupResponse.MasterSlaveServerGroupId = _ctx.StringValue("CreateMasterSlaveServerGroup.MasterSlaveServerGroupId");

			List<CreateMasterSlaveServerGroupResponse.CreateMasterSlaveServerGroup_MasterSlaveBackendServer> createMasterSlaveServerGroupResponse_masterSlaveBackendServers = new List<CreateMasterSlaveServerGroupResponse.CreateMasterSlaveServerGroup_MasterSlaveBackendServer>();
			for (int i = 0; i < _ctx.Length("CreateMasterSlaveServerGroup.MasterSlaveBackendServers.Length"); i++) {
				CreateMasterSlaveServerGroupResponse.CreateMasterSlaveServerGroup_MasterSlaveBackendServer masterSlaveBackendServer = new CreateMasterSlaveServerGroupResponse.CreateMasterSlaveServerGroup_MasterSlaveBackendServer();
				masterSlaveBackendServer.ServerId = _ctx.StringValue("CreateMasterSlaveServerGroup.MasterSlaveBackendServers["+ i +"].ServerId");
				masterSlaveBackendServer.Port = _ctx.IntegerValue("CreateMasterSlaveServerGroup.MasterSlaveBackendServers["+ i +"].Port");
				masterSlaveBackendServer.Weight = _ctx.IntegerValue("CreateMasterSlaveServerGroup.MasterSlaveBackendServers["+ i +"].Weight");
				masterSlaveBackendServer.ServerType = _ctx.StringValue("CreateMasterSlaveServerGroup.MasterSlaveBackendServers["+ i +"].ServerType");
				masterSlaveBackendServer.Type = _ctx.StringValue("CreateMasterSlaveServerGroup.MasterSlaveBackendServers["+ i +"].Type");
				masterSlaveBackendServer.ServerIp = _ctx.StringValue("CreateMasterSlaveServerGroup.MasterSlaveBackendServers["+ i +"].ServerIp");
				masterSlaveBackendServer.VpcId = _ctx.StringValue("CreateMasterSlaveServerGroup.MasterSlaveBackendServers["+ i +"].VpcId");
				masterSlaveBackendServer.Description = _ctx.StringValue("CreateMasterSlaveServerGroup.MasterSlaveBackendServers["+ i +"].Description");

				createMasterSlaveServerGroupResponse_masterSlaveBackendServers.Add(masterSlaveBackendServer);
			}
			createMasterSlaveServerGroupResponse.MasterSlaveBackendServers = createMasterSlaveServerGroupResponse_masterSlaveBackendServers;
        
			return createMasterSlaveServerGroupResponse;
        }
    }
}
