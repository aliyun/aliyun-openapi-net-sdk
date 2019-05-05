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
    public class SetVServerGroupAttributeResponseUnmarshaller
    {
        public static SetVServerGroupAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			SetVServerGroupAttributeResponse setVServerGroupAttributeResponse = new SetVServerGroupAttributeResponse();

			setVServerGroupAttributeResponse.HttpResponse = context.HttpResponse;
			setVServerGroupAttributeResponse.RequestId = context.StringValue("SetVServerGroupAttribute.RequestId");
			setVServerGroupAttributeResponse.VServerGroupId = context.StringValue("SetVServerGroupAttribute.VServerGroupId");
			setVServerGroupAttributeResponse.VServerGroupName = context.StringValue("SetVServerGroupAttribute.VServerGroupName");

			List<SetVServerGroupAttributeResponse.SetVServerGroupAttribute_BackendServer> setVServerGroupAttributeResponse_backendServers = new List<SetVServerGroupAttributeResponse.SetVServerGroupAttribute_BackendServer>();
			for (int i = 0; i < context.Length("SetVServerGroupAttribute.BackendServers.Length"); i++) {
				SetVServerGroupAttributeResponse.SetVServerGroupAttribute_BackendServer backendServer = new SetVServerGroupAttributeResponse.SetVServerGroupAttribute_BackendServer();
				backendServer.ServerId = context.StringValue("SetVServerGroupAttribute.BackendServers["+ i +"].ServerId");
				backendServer.Port = context.IntegerValue("SetVServerGroupAttribute.BackendServers["+ i +"].Port");
				backendServer.Weight = context.IntegerValue("SetVServerGroupAttribute.BackendServers["+ i +"].Weight");
				backendServer.Type = context.StringValue("SetVServerGroupAttribute.BackendServers["+ i +"].Type");
				backendServer.ServerIp = context.StringValue("SetVServerGroupAttribute.BackendServers["+ i +"].ServerIp");
				backendServer.VpcId = context.StringValue("SetVServerGroupAttribute.BackendServers["+ i +"].VpcId");
				backendServer.Description = context.StringValue("SetVServerGroupAttribute.BackendServers["+ i +"].Description");

				setVServerGroupAttributeResponse_backendServers.Add(backendServer);
			}
			setVServerGroupAttributeResponse.BackendServers = setVServerGroupAttributeResponse_backendServers;
        
			return setVServerGroupAttributeResponse;
        }
    }
}
