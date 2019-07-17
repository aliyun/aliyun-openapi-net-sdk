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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListAgentDevicesResponseUnmarshaller
    {
        public static ListAgentDevicesResponse Unmarshall(UnmarshallerContext context)
        {
			ListAgentDevicesResponse listAgentDevicesResponse = new ListAgentDevicesResponse();

			listAgentDevicesResponse.HttpResponse = context.HttpResponse;
			listAgentDevicesResponse.RequestId = context.StringValue("ListAgentDevices.RequestId");
			listAgentDevicesResponse.Success = context.BooleanValue("ListAgentDevices.Success");
			listAgentDevicesResponse.Code = context.StringValue("ListAgentDevices.Code");
			listAgentDevicesResponse.Message = context.StringValue("ListAgentDevices.Message");
			listAgentDevicesResponse.HttpStatusCode = context.IntegerValue("ListAgentDevices.HttpStatusCode");

			List<ListAgentDevicesResponse.ListAgentDevices_AgentDevice> listAgentDevicesResponse_agentDeviceList = new List<ListAgentDevicesResponse.ListAgentDevices_AgentDevice>();
			for (int i = 0; i < context.Length("ListAgentDevices.AgentDeviceList.Length"); i++) {
				ListAgentDevicesResponse.ListAgentDevices_AgentDevice agentDevice = new ListAgentDevicesResponse.ListAgentDevices_AgentDevice();
				agentDevice.InstanceId = context.StringValue("ListAgentDevices.AgentDeviceList["+ i +"].InstanceId");
				agentDevice.RamId = context.LongValue("ListAgentDevices.AgentDeviceList["+ i +"].RamId");
				agentDevice.LoginTime = context.LongValue("ListAgentDevices.AgentDeviceList["+ i +"].LoginTime");
				agentDevice.ClientIp = context.StringValue("ListAgentDevices.AgentDeviceList["+ i +"].ClientIp");
				agentDevice.ClientPort = context.StringValue("ListAgentDevices.AgentDeviceList["+ i +"].ClientPort");
				agentDevice.BrowserVersion = context.StringValue("ListAgentDevices.AgentDeviceList["+ i +"].BrowserVersion");
				agentDevice.IsLogin = context.IntegerValue("ListAgentDevices.AgentDeviceList["+ i +"].IsLogin");
				agentDevice.Remark = context.StringValue("ListAgentDevices.AgentDeviceList["+ i +"].Remark");

				listAgentDevicesResponse_agentDeviceList.Add(agentDevice);
			}
			listAgentDevicesResponse.AgentDeviceList = listAgentDevicesResponse_agentDeviceList;
        
			return listAgentDevicesResponse;
        }
    }
}
