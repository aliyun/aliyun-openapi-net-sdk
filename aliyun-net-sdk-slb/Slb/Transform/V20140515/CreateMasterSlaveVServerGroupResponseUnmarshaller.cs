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
    public class CreateMasterSlaveVServerGroupResponseUnmarshaller
    {
        public static CreateMasterSlaveVServerGroupResponse Unmarshall(UnmarshallerContext context)
        {
			CreateMasterSlaveVServerGroupResponse createMasterSlaveVServerGroupResponse = new CreateMasterSlaveVServerGroupResponse();

			createMasterSlaveVServerGroupResponse.HttpResponse = context.HttpResponse;
			createMasterSlaveVServerGroupResponse.RequestId = context.StringValue("CreateMasterSlaveVServerGroup.RequestId");
			createMasterSlaveVServerGroupResponse.MasterSlaveVServerGroupId = context.StringValue("CreateMasterSlaveVServerGroup.MasterSlaveVServerGroupId");

			List<CreateMasterSlaveVServerGroupResponse.CreateMasterSlaveVServerGroup_MasterSlaveBackendServer> createMasterSlaveVServerGroupResponse_masterSlaveBackendServers = new List<CreateMasterSlaveVServerGroupResponse.CreateMasterSlaveVServerGroup_MasterSlaveBackendServer>();
			for (int i = 0; i < context.Length("CreateMasterSlaveVServerGroup.MasterSlaveBackendServers.Length"); i++) {
				CreateMasterSlaveVServerGroupResponse.CreateMasterSlaveVServerGroup_MasterSlaveBackendServer masterSlaveBackendServer = new CreateMasterSlaveVServerGroupResponse.CreateMasterSlaveVServerGroup_MasterSlaveBackendServer();
				masterSlaveBackendServer.ServerId = context.StringValue("CreateMasterSlaveVServerGroup.MasterSlaveBackendServers["+ i +"].ServerId");
				masterSlaveBackendServer.Port = context.IntegerValue("CreateMasterSlaveVServerGroup.MasterSlaveBackendServers["+ i +"].Port");
				masterSlaveBackendServer.Weight = context.IntegerValue("CreateMasterSlaveVServerGroup.MasterSlaveBackendServers["+ i +"].Weight");
				masterSlaveBackendServer.IsBackup = context.IntegerValue("CreateMasterSlaveVServerGroup.MasterSlaveBackendServers["+ i +"].IsBackup");

				createMasterSlaveVServerGroupResponse_masterSlaveBackendServers.Add(masterSlaveBackendServer);
			}
			createMasterSlaveVServerGroupResponse.MasterSlaveBackendServers = createMasterSlaveVServerGroupResponse_masterSlaveBackendServers;
        
			return createMasterSlaveVServerGroupResponse;
        }
    }
}