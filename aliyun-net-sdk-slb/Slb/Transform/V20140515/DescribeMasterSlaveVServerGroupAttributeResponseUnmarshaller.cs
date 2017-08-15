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
    public class DescribeMasterSlaveVServerGroupAttributeResponseUnmarshaller
    {
        public static DescribeMasterSlaveVServerGroupAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMasterSlaveVServerGroupAttributeResponse describeMasterSlaveVServerGroupAttributeResponse = new DescribeMasterSlaveVServerGroupAttributeResponse();

			describeMasterSlaveVServerGroupAttributeResponse.HttpResponse = context.HttpResponse;
			describeMasterSlaveVServerGroupAttributeResponse.RequestId = context.StringValue("DescribeMasterSlaveVServerGroupAttribute.RequestId");
			describeMasterSlaveVServerGroupAttributeResponse.MasterSlaveVServerGroupId = context.StringValue("DescribeMasterSlaveVServerGroupAttribute.MasterSlaveVServerGroupId");
			describeMasterSlaveVServerGroupAttributeResponse.MasterSlaveVServerGroupName = context.StringValue("DescribeMasterSlaveVServerGroupAttribute.MasterSlaveVServerGroupName");

			List<DescribeMasterSlaveVServerGroupAttributeResponse.DescribeMasterSlaveVServerGroupAttribute_MasterSlaveBackendServer> describeMasterSlaveVServerGroupAttributeResponse_masterSlaveBackendServers = new List<DescribeMasterSlaveVServerGroupAttributeResponse.DescribeMasterSlaveVServerGroupAttribute_MasterSlaveBackendServer>();
			for (int i = 0; i < context.Length("DescribeMasterSlaveVServerGroupAttribute.MasterSlaveBackendServers.Length"); i++) {
				DescribeMasterSlaveVServerGroupAttributeResponse.DescribeMasterSlaveVServerGroupAttribute_MasterSlaveBackendServer masterSlaveBackendServer = new DescribeMasterSlaveVServerGroupAttributeResponse.DescribeMasterSlaveVServerGroupAttribute_MasterSlaveBackendServer();
				masterSlaveBackendServer.ServerId = context.StringValue("DescribeMasterSlaveVServerGroupAttribute.MasterSlaveBackendServers["+ i +"].ServerId");
				masterSlaveBackendServer.Port = context.IntegerValue("DescribeMasterSlaveVServerGroupAttribute.MasterSlaveBackendServers["+ i +"].Port");
				masterSlaveBackendServer.Weight = context.IntegerValue("DescribeMasterSlaveVServerGroupAttribute.MasterSlaveBackendServers["+ i +"].Weight");
				masterSlaveBackendServer.IsBackup = context.IntegerValue("DescribeMasterSlaveVServerGroupAttribute.MasterSlaveBackendServers["+ i +"].IsBackup");

				describeMasterSlaveVServerGroupAttributeResponse_masterSlaveBackendServers.Add(masterSlaveBackendServer);
			}
			describeMasterSlaveVServerGroupAttributeResponse.MasterSlaveBackendServers = describeMasterSlaveVServerGroupAttributeResponse_masterSlaveBackendServers;
        
			return describeMasterSlaveVServerGroupAttributeResponse;
        }
    }
}