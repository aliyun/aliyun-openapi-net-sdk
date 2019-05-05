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
    public class SetBackendServersResponseUnmarshaller
    {
        public static SetBackendServersResponse Unmarshall(UnmarshallerContext context)
        {
			SetBackendServersResponse setBackendServersResponse = new SetBackendServersResponse();

			setBackendServersResponse.HttpResponse = context.HttpResponse;
			setBackendServersResponse.RequestId = context.StringValue("SetBackendServers.RequestId");
			setBackendServersResponse.LoadBalancerId = context.StringValue("SetBackendServers.LoadBalancerId");

			List<SetBackendServersResponse.SetBackendServers_BackendServer> setBackendServersResponse_backendServers = new List<SetBackendServersResponse.SetBackendServers_BackendServer>();
			for (int i = 0; i < context.Length("SetBackendServers.BackendServers.Length"); i++) {
				SetBackendServersResponse.SetBackendServers_BackendServer backendServer = new SetBackendServersResponse.SetBackendServers_BackendServer();
				backendServer.ServerId = context.StringValue("SetBackendServers.BackendServers["+ i +"].ServerId");
				backendServer.Weight = context.StringValue("SetBackendServers.BackendServers["+ i +"].Weight");
				backendServer.ServerIp = context.StringValue("SetBackendServers.BackendServers["+ i +"].ServerIp");
				backendServer.VpcId = context.StringValue("SetBackendServers.BackendServers["+ i +"].VpcId");
				backendServer.Type = context.StringValue("SetBackendServers.BackendServers["+ i +"].Type");
				backendServer.Description = context.StringValue("SetBackendServers.BackendServers["+ i +"].Description");

				setBackendServersResponse_backendServers.Add(backendServer);
			}
			setBackendServersResponse.BackendServers = setBackendServersResponse_backendServers;
        
			return setBackendServersResponse;
        }
    }
}
