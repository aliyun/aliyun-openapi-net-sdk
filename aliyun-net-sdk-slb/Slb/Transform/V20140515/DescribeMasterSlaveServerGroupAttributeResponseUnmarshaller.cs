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
    public class DescribeMasterSlaveServerGroupAttributeResponseUnmarshaller
    {
        public static DescribeMasterSlaveServerGroupAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMasterSlaveServerGroupAttributeResponse describeMasterSlaveServerGroupAttributeResponse = new DescribeMasterSlaveServerGroupAttributeResponse();

			describeMasterSlaveServerGroupAttributeResponse.HttpResponse = context.HttpResponse;
			describeMasterSlaveServerGroupAttributeResponse.RequestId = context.StringValue("DescribeMasterSlaveServerGroupAttribute.RequestId");
			describeMasterSlaveServerGroupAttributeResponse.MasterSlaveServerGroupId = context.StringValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveServerGroupId");
			describeMasterSlaveServerGroupAttributeResponse.MasterSlaveServerGroupName = context.StringValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveServerGroupName");

			List<DescribeMasterSlaveServerGroupAttributeResponse.DescribeMasterSlaveServerGroupAttribute_MasterSlaveBackendServer> describeMasterSlaveServerGroupAttributeResponse_masterSlaveBackendServers = new List<DescribeMasterSlaveServerGroupAttributeResponse.DescribeMasterSlaveServerGroupAttribute_MasterSlaveBackendServer>();
			for (int i = 0; i < context.Length("DescribeMasterSlaveServerGroupAttribute.MasterSlaveBackendServers.Length"); i++) {
				DescribeMasterSlaveServerGroupAttributeResponse.DescribeMasterSlaveServerGroupAttribute_MasterSlaveBackendServer masterSlaveBackendServer = new DescribeMasterSlaveServerGroupAttributeResponse.DescribeMasterSlaveServerGroupAttribute_MasterSlaveBackendServer();
				masterSlaveBackendServer.ServerId = context.StringValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveBackendServers["+ i +"].ServerId");
				masterSlaveBackendServer.Port = context.IntegerValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveBackendServers["+ i +"].Port");
				masterSlaveBackendServer.Weight = context.IntegerValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveBackendServers["+ i +"].Weight");
				masterSlaveBackendServer.ServerType = context.StringValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveBackendServers["+ i +"].ServerType");

				describeMasterSlaveServerGroupAttributeResponse_masterSlaveBackendServers.Add(masterSlaveBackendServer);
			}
			describeMasterSlaveServerGroupAttributeResponse.MasterSlaveBackendServers = describeMasterSlaveServerGroupAttributeResponse_masterSlaveBackendServers;
        
			return describeMasterSlaveServerGroupAttributeResponse;
        }
    }
}