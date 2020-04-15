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
    public class DescribeSagPortListResponseUnmarshaller
    {
        public static DescribeSagPortListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSagPortListResponse describeSagPortListResponse = new DescribeSagPortListResponse();

			describeSagPortListResponse.HttpResponse = context.HttpResponse;
			describeSagPortListResponse.RequestId = context.StringValue("DescribeSagPortList.RequestId");

			List<DescribeSagPortListResponse.DescribeSagPortList_Port> describeSagPortListResponse_ports = new List<DescribeSagPortListResponse.DescribeSagPortList_Port>();
			for (int i = 0; i < context.Length("DescribeSagPortList.Ports.Length"); i++) {
				DescribeSagPortListResponse.DescribeSagPortList_Port port = new DescribeSagPortListResponse.DescribeSagPortList_Port();
				port.PortName = context.StringValue("DescribeSagPortList.Ports["+ i +"].PortName");
				port.Role = context.StringValue("DescribeSagPortList.Ports["+ i +"].Role");
				port.Mac = context.StringValue("DescribeSagPortList.Ports["+ i +"].Mac");
				port.Status = context.StringValue("DescribeSagPortList.Ports["+ i +"].Status");

				describeSagPortListResponse_ports.Add(port);
			}
			describeSagPortListResponse.Ports = describeSagPortListResponse_ports;

			List<DescribeSagPortListResponse.DescribeSagPortList_TaskState> describeSagPortListResponse_taskStates = new List<DescribeSagPortListResponse.DescribeSagPortList_TaskState>();
			for (int i = 0; i < context.Length("DescribeSagPortList.TaskStates.Length"); i++) {
				DescribeSagPortListResponse.DescribeSagPortList_TaskState taskState = new DescribeSagPortListResponse.DescribeSagPortList_TaskState();
				taskState.State = context.StringValue("DescribeSagPortList.TaskStates["+ i +"].State");
				taskState.ErrorCode = context.StringValue("DescribeSagPortList.TaskStates["+ i +"].ErrorCode");
				taskState.ErrorMessage = context.StringValue("DescribeSagPortList.TaskStates["+ i +"].ErrorMessage");
				taskState.CreateTime = context.StringValue("DescribeSagPortList.TaskStates["+ i +"].CreateTime");

				describeSagPortListResponse_taskStates.Add(taskState);
			}
			describeSagPortListResponse.TaskStates = describeSagPortListResponse_taskStates;
        
			return describeSagPortListResponse;
        }
    }
}
