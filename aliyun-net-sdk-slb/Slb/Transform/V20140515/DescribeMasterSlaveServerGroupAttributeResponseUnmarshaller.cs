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
    public class DescribeMasterSlaveServerGroupAttributeResponseUnmarshaller
    {
        public static DescribeMasterSlaveServerGroupAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMasterSlaveServerGroupAttributeResponse describeMasterSlaveServerGroupAttributeResponse = new DescribeMasterSlaveServerGroupAttributeResponse();

			describeMasterSlaveServerGroupAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeMasterSlaveServerGroupAttributeResponse.RequestId = _ctx.StringValue("DescribeMasterSlaveServerGroupAttribute.RequestId");
			describeMasterSlaveServerGroupAttributeResponse.LoadBalancerId = _ctx.StringValue("DescribeMasterSlaveServerGroupAttribute.LoadBalancerId");
			describeMasterSlaveServerGroupAttributeResponse.MasterSlaveServerGroupId = _ctx.StringValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveServerGroupId");
			describeMasterSlaveServerGroupAttributeResponse.MasterSlaveServerGroupName = _ctx.StringValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveServerGroupName");

			List<DescribeMasterSlaveServerGroupAttributeResponse.DescribeMasterSlaveServerGroupAttribute_MasterSlaveBackendServer> describeMasterSlaveServerGroupAttributeResponse_masterSlaveBackendServers = new List<DescribeMasterSlaveServerGroupAttributeResponse.DescribeMasterSlaveServerGroupAttribute_MasterSlaveBackendServer>();
			for (int i = 0; i < _ctx.Length("DescribeMasterSlaveServerGroupAttribute.MasterSlaveBackendServers.Length"); i++) {
				DescribeMasterSlaveServerGroupAttributeResponse.DescribeMasterSlaveServerGroupAttribute_MasterSlaveBackendServer masterSlaveBackendServer = new DescribeMasterSlaveServerGroupAttributeResponse.DescribeMasterSlaveServerGroupAttribute_MasterSlaveBackendServer();
				masterSlaveBackendServer.ServerId = _ctx.StringValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveBackendServers["+ i +"].ServerId");
				masterSlaveBackendServer.Port = _ctx.IntegerValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveBackendServers["+ i +"].Port");
				masterSlaveBackendServer.Weight = _ctx.IntegerValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveBackendServers["+ i +"].Weight");
				masterSlaveBackendServer.ServerType = _ctx.StringValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveBackendServers["+ i +"].ServerType");
				masterSlaveBackendServer.Type = _ctx.StringValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveBackendServers["+ i +"].Type");
				masterSlaveBackendServer.ServerIp = _ctx.StringValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveBackendServers["+ i +"].ServerIp");
				masterSlaveBackendServer.VpcId = _ctx.StringValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveBackendServers["+ i +"].VpcId");
				masterSlaveBackendServer.Description = _ctx.StringValue("DescribeMasterSlaveServerGroupAttribute.MasterSlaveBackendServers["+ i +"].Description");

				describeMasterSlaveServerGroupAttributeResponse_masterSlaveBackendServers.Add(masterSlaveBackendServer);
			}
			describeMasterSlaveServerGroupAttributeResponse.MasterSlaveBackendServers = describeMasterSlaveServerGroupAttributeResponse_masterSlaveBackendServers;
        
			return describeMasterSlaveServerGroupAttributeResponse;
        }
    }
}
