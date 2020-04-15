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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeSagPortRouteProtocolListResponseUnmarshaller
    {
        public static DescribeSagPortRouteProtocolListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSagPortRouteProtocolListResponse describeSagPortRouteProtocolListResponse = new DescribeSagPortRouteProtocolListResponse();

			describeSagPortRouteProtocolListResponse.HttpResponse = context.HttpResponse;
			describeSagPortRouteProtocolListResponse.RequestId = context.StringValue("DescribeSagPortRouteProtocolList.RequestId");

			List<DescribeSagPortRouteProtocolListResponse.DescribeSagPortRouteProtocolList_Port> describeSagPortRouteProtocolListResponse_ports = new List<DescribeSagPortRouteProtocolListResponse.DescribeSagPortRouteProtocolList_Port>();
			for (int i = 0; i < context.Length("DescribeSagPortRouteProtocolList.Ports.Length"); i++) {
				DescribeSagPortRouteProtocolListResponse.DescribeSagPortRouteProtocolList_Port port = new DescribeSagPortRouteProtocolListResponse.DescribeSagPortRouteProtocolList_Port();
				port.PortName = context.StringValue("DescribeSagPortRouteProtocolList.Ports["+ i +"].PortName");
				port.RouteProtocol = context.StringValue("DescribeSagPortRouteProtocolList.Ports["+ i +"].RouteProtocol");
				port.RemoteIp = context.StringValue("DescribeSagPortRouteProtocolList.Ports["+ i +"].RemoteIp");
				port.RemoteAs = context.StringValue("DescribeSagPortRouteProtocolList.Ports["+ i +"].RemoteAs");
				port.Vlan = context.StringValue("DescribeSagPortRouteProtocolList.Ports["+ i +"].Vlan");
				port.Status = context.StringValue("DescribeSagPortRouteProtocolList.Ports["+ i +"].Status");
				port.NeighborIp = context.StringValue("DescribeSagPortRouteProtocolList.Ports["+ i +"].NeighborIp");

				describeSagPortRouteProtocolListResponse_ports.Add(port);
			}
			describeSagPortRouteProtocolListResponse.Ports = describeSagPortRouteProtocolListResponse_ports;

			List<DescribeSagPortRouteProtocolListResponse.DescribeSagPortRouteProtocolList_TaskState> describeSagPortRouteProtocolListResponse_taskStates = new List<DescribeSagPortRouteProtocolListResponse.DescribeSagPortRouteProtocolList_TaskState>();
			for (int i = 0; i < context.Length("DescribeSagPortRouteProtocolList.TaskStates.Length"); i++) {
				DescribeSagPortRouteProtocolListResponse.DescribeSagPortRouteProtocolList_TaskState taskState = new DescribeSagPortRouteProtocolListResponse.DescribeSagPortRouteProtocolList_TaskState();
				taskState.State = context.StringValue("DescribeSagPortRouteProtocolList.TaskStates["+ i +"].State");
				taskState.ErrorCode = context.StringValue("DescribeSagPortRouteProtocolList.TaskStates["+ i +"].ErrorCode");
				taskState.ErrorMessage = context.StringValue("DescribeSagPortRouteProtocolList.TaskStates["+ i +"].ErrorMessage");
				taskState.CreateTime = context.StringValue("DescribeSagPortRouteProtocolList.TaskStates["+ i +"].CreateTime");

				describeSagPortRouteProtocolListResponse_taskStates.Add(taskState);
			}
			describeSagPortRouteProtocolListResponse.TaskStates = describeSagPortRouteProtocolListResponse_taskStates;
        
			return describeSagPortRouteProtocolListResponse;
        }
    }
}
