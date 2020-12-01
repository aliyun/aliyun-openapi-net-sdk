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
        public static ListAgentDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAgentDevicesResponse listAgentDevicesResponse = new ListAgentDevicesResponse();

			listAgentDevicesResponse.HttpResponse = _ctx.HttpResponse;
			listAgentDevicesResponse.RequestId = _ctx.StringValue("ListAgentDevices.RequestId");
			listAgentDevicesResponse.Success = _ctx.BooleanValue("ListAgentDevices.Success");
			listAgentDevicesResponse.Code = _ctx.StringValue("ListAgentDevices.Code");
			listAgentDevicesResponse.Message = _ctx.StringValue("ListAgentDevices.Message");
			listAgentDevicesResponse.HttpStatusCode = _ctx.IntegerValue("ListAgentDevices.HttpStatusCode");

			List<ListAgentDevicesResponse.ListAgentDevices_AgentDevice> listAgentDevicesResponse_agentDeviceList = new List<ListAgentDevicesResponse.ListAgentDevices_AgentDevice>();
			for (int i = 0; i < _ctx.Length("ListAgentDevices.AgentDeviceList.Length"); i++) {
				ListAgentDevicesResponse.ListAgentDevices_AgentDevice agentDevice = new ListAgentDevicesResponse.ListAgentDevices_AgentDevice();
				agentDevice.InstanceId = _ctx.StringValue("ListAgentDevices.AgentDeviceList["+ i +"].InstanceId");
				agentDevice.RamId = _ctx.LongValue("ListAgentDevices.AgentDeviceList["+ i +"].RamId");
				agentDevice.LoginTime = _ctx.LongValue("ListAgentDevices.AgentDeviceList["+ i +"].LoginTime");
				agentDevice.ClientIp = _ctx.StringValue("ListAgentDevices.AgentDeviceList["+ i +"].ClientIp");
				agentDevice.ClientPort = _ctx.StringValue("ListAgentDevices.AgentDeviceList["+ i +"].ClientPort");
				agentDevice.BrowserVersion = _ctx.StringValue("ListAgentDevices.AgentDeviceList["+ i +"].BrowserVersion");
				agentDevice.IsLogin = _ctx.IntegerValue("ListAgentDevices.AgentDeviceList["+ i +"].IsLogin");
				agentDevice.Remark = _ctx.StringValue("ListAgentDevices.AgentDeviceList["+ i +"].Remark");

				listAgentDevicesResponse_agentDeviceList.Add(agentDevice);
			}
			listAgentDevicesResponse.AgentDeviceList = listAgentDevicesResponse_agentDeviceList;
        
			return listAgentDevicesResponse;
        }
    }
}
